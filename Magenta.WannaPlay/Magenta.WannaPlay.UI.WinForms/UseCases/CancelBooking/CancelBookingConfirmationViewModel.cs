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
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class CancelBookingConfirmationViewModel : ViewModelBase
    {
        [Inject]
        [Browsable(false)]
        public IBookingService BookingService { get; set; }

        [Inject]
        [Browsable(false)]
        public IKernel Kernel { get; set; }


        BookingEntry _booking;
        [Browsable(false)]
        public BookingEntry Booking
        {
            get { return _booking; }
            set { _booking = value; OnBookingChanged(); }
        }

        BookingEntryEditorViewModel _bookingViewModel;
        public BookingEntryEditorViewModel BookingViewModel
        {
            get { return _bookingViewModel; }
            private set { _bookingViewModel = value; OnPropertyChanged("BookingViewModel"); }
        }

        private void OnBookingChanged()
        {
            var bookingViewModel = Kernel.Get<BookingEntryEditorViewModel>();
            bookingViewModel.Underlying = Booking;

            BookingViewModel = bookingViewModel;
        }

        public void DoCancel()
        {
            BookingService.CancelBookingEntry(Booking);
        }
    }
}
