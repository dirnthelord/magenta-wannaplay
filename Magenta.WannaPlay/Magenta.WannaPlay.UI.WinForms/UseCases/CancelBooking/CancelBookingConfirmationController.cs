using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using System.ComponentModel;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.CancelBooking
{
    public class CancelBookingConfirmationController
    {
        [Inject]
        [Browsable(false)]
        public IBookingService BookingService { get; set; }


        public void CancelBooking(BookingEntry booking)
        {
            BookingService.CancelBooking(booking);
        }
    }
}
