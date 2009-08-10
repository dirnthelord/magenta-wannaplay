using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared.Ui.WinForms;
using Magenta.Shared.UI.WinForms;
using Magenta.WannaPlay.UI.WinForms.Controls.GridCells;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.Domain;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.Shared.UI.WinForms.Controls;
using Magenta.Shared.DesignByContract;
using Magenta.Shared.Exceptions;
using Magenta.WannaPlay.UI.WinForms.UseCases.ViewBookingSchedule;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class BookingScheduleControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Bindable(true)]
        public BookingScheduleViewModel ViewModel
        {
            get { return (BookingScheduleViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        public BookingScheduleControl()
        {
            InitializeComponent();

            bookingScheduleGrid.AutoGenerateColumns = false;
            addBookingButton.Image = Resources.AddBooking.As16x16Bitmap();
            findBookingButton.Image = Resources.Search.As16x16Bitmap();
            cancelBookingButton.Image = Resources.Cancel.As16x16Bitmap();
        }

        private void dataContext_DataSourceChanged(object sender, EventArgs e)
        {
            RecreateColumns();
            FillGridWithData();
        }

        #region Columns
        void RecreateColumns()
        {
            RemoveAllColumns();
            AddPeriodColumns();
            AddFacilityColumns();
        }

        private void RemoveAllColumns()
        {
            bookingScheduleGrid.Columns.Clear();
        }

        private void AddPeriodColumns()
        {
            bookingScheduleGrid.Columns.Add(CreatePeriodColumn("From", PeriodColumnType.From));
            bookingScheduleGrid.Columns.Add(CreatePeriodColumn("To", PeriodColumnType.To));
        }

        enum PeriodColumnType
        {
            From = 1,
            To = 2,
        }

        private static DataGridViewTextBoxColumn CreatePeriodColumn(string header, PeriodColumnType type)
        {
            var column = new DataGridViewTextBoxColumn
            {
                HeaderText = header,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                Tag = type,
            };

            column.DefaultCellStyle.BackColor = SystemColors.Info;

            return column;
        }

        bool IsPeriodColumn(int columnIndex)
        {
            return bookingScheduleGrid.Columns[columnIndex].Tag is PeriodColumnType;
        }

        void AddFacilityColumns()
        {
            foreach (var facility in ViewModel.Facilities)
                bookingScheduleGrid.Columns.Add(CreateFacilityBookingColumn(facility));
        }

        DataGridViewColumn CreateFacilityBookingColumn(Facility facility)
        {
            return new BookingSlotColumn
            {
                HeaderText = facility.Name,
                Tag = facility,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
        }
        #endregion

        #region Booking management

        private void FindBookingClicked(object sender, EventArgs e)
        {
            ViewModel.FindBookings();
        }

        private void AddBookingClicked(object sender, EventArgs e)
        {
            ViewModel.AddBookingToSelected();
        }

        private void ScheduleGridCellMouseDoubleClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewModel.AddOrCancelSelectedBooking();
        }

        private void cancelBookingClicked(object sender, EventArgs e)
        {
            ViewModel.CancelSelectedBooking();
        }

        #endregion

        #region Row, column and cell values
        private void FillGridWithData()
        {
            bookingScheduleGrid.DataSource = ViewModel.BookingPeriods;
        }

        DateTimePeriod GetPeriod(int rowIndex)
        {
            if (rowIndex < 0)
                return null;

            return (DateTimePeriod)bookingScheduleGrid.Rows[rowIndex].DataBoundItem;
        }

        Facility GetFacility(int columnIndex)
        {
            if (columnIndex < 0)
                return null;

            return bookingScheduleGrid.Columns[columnIndex].Tag as Facility;
        }

        public BookingSlot GetBookingSlot(DataGridViewCell cell)
        {
            return GetBookingSlot(cell.RowIndex, cell.ColumnIndex);
        }

        public BookingSlot GetBookingSlot(int rowIndex, int columnIndex)
        {
            var slotPeriod = GetPeriod(rowIndex);
            var facility = GetFacility(columnIndex);

            if (slotPeriod == null || facility == null)
                return null;

            return ViewModel.GetBookingSlot(slotPeriod, facility);
        }

        bool IsFacilityColumn(int columnIndex)
        {
            return GetFacility(columnIndex) != null;
        }

        bool IsPeriodRow(int rowIndex)
        {
            return GetPeriod(rowIndex) != null;
        }

        private void bookingScheduleGrid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            RequireArg.Complies(IsPeriodRow(e.RowIndex));

            if (IsFacilityColumn(e.ColumnIndex))
            {
                e.Value = GetBookingSlot(e.RowIndex, e.ColumnIndex);
                return;
            }

            if (IsPeriodColumn(e.ColumnIndex))
                e.Value = GetPeriodCellValue(e.RowIndex, e.ColumnIndex);
        }

        string GetPeriodCellValue(int rowIndex, int columnIndex)
        {
            var time = GetPeriodColumnTime(rowIndex, columnIndex);
            return time.ToString("h.mmtt");
        }

        DateTime GetPeriodColumnTime(int rowIndex, int columnIndex)
        {
            var period = RequireArg.NotNull(GetPeriod(rowIndex));

            var periodColumnType = GetPeriodColumnType(columnIndex);

            switch (periodColumnType)
            {
                case PeriodColumnType.From:
                    return period.From;

                case PeriodColumnType.To:
                    return period.To;
            }

            throw ExceptionFactory.NotSupported("PeriodColumnType '{0}' is not supported", periodColumnType);
        }

        PeriodColumnType GetPeriodColumnType(int columnIndex)
        {
            return (PeriodColumnType)bookingScheduleGrid.Columns[columnIndex].Tag;
        }
        #endregion

        #region Selection
        void bookingScheduleGrid_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
        {
            // Only cells in facility-related columns and in slotPeriod-related rows should be selectable
            if (!IsFacilityColumn(e.ColumnIndex) || !IsPeriodRow(e.RowIndex))
                e.Cancel = true;
        }

        private void bookingScheduleGrid_SelectionChanged(object sender, EventArgs e)
        {
            ViewModel.SelectedBookingSlots = SelectedSlots;
        }

        public IEnumerable<BookingSlot> SelectedSlots
        {
            get
            {
                return bookingScheduleGrid.SelectedCells
                    .Cast<DataGridViewCell>()
                    .Select(cell => GetBookingSlot(cell))
                    .Where(s => s != null);
            }
        }
        #endregion

        private void bookingScheduleGrid_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (!IsPeriodRow(e.RowIndex))
                return;

            if (IsFacilityColumn(e.ColumnIndex))
                e.ToolTipText = ViewModel.GetSlotToolTip(GetBookingSlot(e.RowIndex, e.ColumnIndex));

        }
    }
}
