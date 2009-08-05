using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class CancelBookingConfirmationViewModel : ViewModelBase
    {
        public IBookingService BookingService { get; set; }

        BookingEntryUI _bookingUI;
        public BookingEntryUI BookingUI 
        {
            get { return _bookingUI; }
            private set { _bookingUI = value; OnPropertyChanged("BookingUI"); }
        }

        [Browsable(false)]
        public BookingEntry Booking
        {
            get { return BookingUI.Booking; }
            set { BookingUI = new BookingEntryUI(Booking); }
        }

        public CancelBookingConfirmationViewModel(IBookingService bookingService)
        {
            BookingService = RequireArg.NotNull(bookingService);
        }

        public void DoCancel()
        {
            BookingService.CancelBookingEntry(Booking);
        }
    }
}
