using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Controls.GridCells;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.Domain;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.Shared.UI.WinForms.Controls;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class BookingScheduleControl : UserControl
    {
        [Inject]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookingScheduleViewModel ViewModel
        {
            get { return (BookingScheduleViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        public BookingScheduleControl()
        {
            InitializeComponent();

            dataContext.DataSourceChanged += delegate { CreateFacilityColumns(); FillGridWithData(); };

            bookingScheduleGrid.SelectionChanged += delegate { OnSelectedSlotsChanged(); };
        
            // TODO: Move to designer-generated code
            bookingScheduleGrid.VirtualMode = true;
            bookingScheduleGrid.KeyDown += bookingScheduleGrid_KeyDown;
            bookingScheduleGrid.ReadOnly = true;
            bookingScheduleGrid.SelectionChanging += bookingScheduleGrid_SelectionChanging;
        }

        void bookingScheduleGrid_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
        {
            if (GetFacility(e.ColumnIndex) == null)
                e.Cancel = true;
        }

        private void FillGridWithData()
        {
            bookingScheduleGrid.DataSource = ViewModel.BookingPeriods;
        }

        void OnSelectedSlotsChanged()
        {
            // TODO: Refactor (?)
            ViewModel.SelectedBookingSlots = SelectedSlots;
        }


        void CreateFacilityColumns()
        {
            // TODO: Remove old facility columns first
            foreach (var facility in ViewModel.Facilities)
                AddFacilityColumn(facility);
        }

        private void bookingScheduleGrid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var bookingSlot = GetBookingSlot(e.RowIndex, e.ColumnIndex);

            if (bookingSlot != null)
            {
                bool isBooked = ViewModel.GetBookingEntries(bookingSlot.ToEnumerable()).Any();
                e.Value = isBooked;
            }
        }

        private void cancelBookingButton_Click(object sender, EventArgs e)
        {
            ViewModel.CancelBookings();
        }

        private void addBookingButton_Click(object sender, EventArgs e)
        {
            ViewModel.AddBookingToSelected();
        }

        private void bookingScheduleGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != 0
                && e.ColumnIndex != bookingScheduleGrid.Columns.Count - 1
                && ViewModel.CanAddBooking)
            {
                ViewModel.AddBookingToSelected();
            }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<BookingEntryUI> ItemsSource
        {
            get { return dataContext.DataSource as BindingList<BookingEntryUI>; }
            set { dataContext.DataSource = value; }
        }

        BookingIndicatorCell _indicatorCellTemplate = new BookingIndicatorCell();

        DataGridViewColumn CreateFacilityBookingColumn(Facility facility)
        {
            return new DataGridViewColumn
            {
                CellTemplate = _indicatorCellTemplate,
                HeaderText = facility.Name,
                Tag = facility,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
        }

        void AddFacilityColumn(Facility facility)
        {
            bookingScheduleGrid.Columns.Add(CreateFacilityBookingColumn(facility));
        }

        #region Rows and columns values
        BookingPeriodUI GetBookingPeriodUI(int rowIndex)
        {
            if (rowIndex < 0)
                return null;

            return (BookingPeriodUI)bookingScheduleGrid.Rows[rowIndex].DataBoundItem;
        }

        Facility GetFacility(int columnIndex)
        {
            if (columnIndex < 0)
                return null;

            var column = bookingScheduleGrid.Columns[columnIndex];
            return column.Tag as Facility;
        }

        public BookingSlot GetBookingSlot(int rowIndex, int columnIndex)
        {
            var period = GetBookingPeriodUI(rowIndex);
            var facility = GetFacility(columnIndex);

            if (period == null || facility == null)
                return null;

            return new BookingSlot { Period = period.Period, Facility = facility };
        }
        #endregion

        void bookingScheduleGrid_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Control | Keys.Enter:
                    ViewModel.AddBookingToSelected();
                    e.Handled = true;
                    break;

                case Keys.Control | Keys.Delete:
                    ViewModel.CancelBookings();
                    e.Handled = true;
                    break;
            }
        }

        public IEnumerable<BookingSlot> SelectedSlots
        {
            get
            {
                return bookingScheduleGrid.SelectedCells
                    .Cast<DataGridViewCell>()
                    .Select(cell => new BookingSlot
                    {
                        Period = GetBookingPeriodUI(cell.RowIndex).Period,
                        Facility = GetFacility(cell.ColumnIndex)
                    });
            }
        }
    }
}
