using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using System.ComponentModel;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared.Aop;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.CancelBooking
{
    public class CancelBookingConfirmationController
    {
        [Inject]
        [Browsable(false)]
        public IBookingService BookingService { get; set; }


        public CancelBookingConfirmationViewModel ViewModel { get; set; }

        
        public CancelBookingConfirmationController()
        {
            ViewModel = ObjectFactory.Create<CancelBookingConfirmationViewModel>();
        }


        public void CancelBooking()
        {
            BookingService.CancelBookingEntry(ViewModel.Booking);
        }

    }
}
