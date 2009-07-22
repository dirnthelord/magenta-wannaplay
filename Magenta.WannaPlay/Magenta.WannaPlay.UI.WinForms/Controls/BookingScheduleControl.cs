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

            dataContext.DataSourceChanged += delegate { CreateFacilityColumns(); FillGridWithData(); };

            bookingScheduleGrid.AddBooking += delegate { ViewModel.AddSelectedBooking(); };
            bookingScheduleGrid.CancelBooking += delegate { ViewModel.CancelSelectedBooking(); };

            bookingScheduleGrid.SelectionChanged += delegate { OnSelectedSlotsChanged(); };

            addBookingButton.Click += delegate { ViewModel.AddSelectedBooking(); };
            cancelBookingButton.Click += delegate { ViewModel.CancelSelectedBooking(); };

            dayPicker.ValueChanged += delegate { ViewModel.Day = dayPicker.Value; };
        }

        private void FillGridWithData()
        {
            bookingScheduleGrid.DataMember = null;
            bookingScheduleGrid.DataSource = ViewModel.BookingPeriods;
        }

        void OnSelectedSlotsChanged()
        {
            ViewModel.SelectedBookingSlots = bookingScheduleGrid.SelectedSlots;
        }


        void CreateFacilityColumns()
        {
            foreach (var facility in ViewModel.Facilities)
                bookingScheduleGrid.AddFacilityColumn(facility);
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
