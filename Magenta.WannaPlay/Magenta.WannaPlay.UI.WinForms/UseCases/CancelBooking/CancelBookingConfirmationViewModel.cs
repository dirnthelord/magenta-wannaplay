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

namespace Magenta.WannaPlay.UI.WinForms.UseCases.CancelBooking
{
    public abstract class CancelBookingConfirmationViewModel : INotifyPropertyChanged
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;

        public abstract BookingEntry Booking { get; set; }

        public virtual void SetContext(BookingEntry booking)
        {
            Booking = booking;
        }
    }
}
