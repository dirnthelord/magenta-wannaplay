using System;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.CommonControls;


namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public class AddBookingViewModel : ViewModelBase
    {
        public BookingEntry Booking { get; set; }

        public string ViewTitle
        {
            get { return "Book '{0}'".FormatString(Booking.Facility.Name); }
        }
    }
}
