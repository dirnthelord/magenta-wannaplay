using System;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.CancelBooking
{
    public class CancelBookingConfirmationViewModel : ViewModelBase
    {
        public BookingEntry Booking { get; set; }

        public string ViewTitle
        {
            get { return "Cancel booking of '{0}'".FormatString(Booking.Facility.Name); }
        }
    }
}
