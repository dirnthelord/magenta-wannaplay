using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.UI.WinForms.Controls.GridCells;
using Magenta.WannaPlay.UI.WinForms.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    internal class BookingScheduleGrid : DataGridView
    {
        public BookingScheduleGrid()
        {
            VirtualMode = true;
            KeyDown += this_KeyDown;
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

        public void AddFacilityColumn(Facility facility)
        {
            Columns.Add(CreateFacilityBookingColumn(facility));
        }

        BookingPeriodUI GetBookingPeriodUI(int rowIndex)
        {
            return (BookingPeriodUI)Rows[rowIndex].DataBoundItem;
        }

        Facility GetFacility(int columnIndex)
        {
            var column = Columns[columnIndex];
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

        protected override void SetSelectedCellCore(int columnIndex, int rowIndex, bool selected)
        {
            if (GetFacility(columnIndex) != null)
                base.SetSelectedCellCore(columnIndex, rowIndex, selected);
        }

        void this_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Control | Keys.Enter:
                    OnAddBooking();
                    e.Handled = true;
                    break;

                case Keys.Control | Keys.Delete:
                    OnDeleteBooking();
                    e.Handled = true;
                    break;
            }
        }

        public IEnumerable<BookingSlot> SelectedSlots
        {
            get
            {
                return SelectedCells
                    .Cast<DataGridViewCell>()
                    .Select(cell => new BookingSlot
                    {
                        Period = GetBookingPeriodUI(cell.RowIndex).Period,
                        Facility = GetFacility(cell.ColumnIndex)
                    });
            }
        }

        void OnDeleteBooking()
        {
            var handler = DeleteBooking;

            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        void OnAddBooking()
        {
            var handler = AddBooking;

            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        public event EventHandler AddBooking;
        public event EventHandler DeleteBooking;
    }
}
