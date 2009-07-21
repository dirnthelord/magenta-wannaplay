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

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class BookingScheduleControl : UserControl
    {
        [Inject]
        public BookingScheduleViewModel ViewModel
        {
            get { return (BookingScheduleViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        public BookingScheduleControl()
        {
            InitializeComponent();

            dataContext.DataSourceChanged += delegate { UpdateGridColumns(); };

            bookingScheduleGrid.AddBooking += delegate { AddBooking(); };
            bookingScheduleGrid.DeleteBooking += delegate { DeleteBooking(); };

            bookingScheduleGrid.SelectionChanged += delegate { OnSelectedSlotsChanged(); };
        }

        IEnumerable<BookingEntry> SelectedBookingEntries
        {
            get { return ViewModel.GetBookingEntries(bookingScheduleGrid.SelectedSlots); }
        }

        bool CanAddBooking
        {
            get { return !SelectedBookingEntries.Any(); }
        }

        bool CanCancelBooking
        {
            get { return SelectedBookingEntries.Any(); }
        }

        void OnSelectedSlotsChanged()
        {
            addBookingButton.Enabled = CanAddBooking;
            cancelBookingButton.Enabled = CanCancelBooking;
        }


        void UpdateGridColumns()
        {
            foreach (var facility in ViewModel.Facilities)
                bookingScheduleGrid.AddFacilityColumn(facility);
        }

        private void addBookingButton_Click(object sender, EventArgs e)
        {
            AddBooking();
        }

        private void cancelBookingButton_Click(object sender, EventArgs e)
        {
            DeleteBooking();
        }

        private void DeleteBooking()
        {
            throw new NotImplementedException();
        }

        private void AddBooking()
        {
            throw new NotImplementedException();
        }

        private void bookingScheduleGrid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var bookingSlot = bookingScheduleGrid.GetBookingSlot(e.RowIndex, e.ColumnIndex);

            if (bookingSlot != null)
            {
                bool isBooked = ViewModel.GetBookingEntries(bookingSlot.ToEnumerable()).Any();
                e.Value = isBooked;
            }
        }
    }
}
