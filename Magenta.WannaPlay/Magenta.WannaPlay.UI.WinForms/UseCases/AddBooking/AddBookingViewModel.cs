using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Ninject.Core;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.Services.Residence;
using Magenta.Shared.DesignByContract;
using System.ComponentModel;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.Shared;
using Magenta.Shared.Aop;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public abstract class AddBookingViewModel : INotifyPropertyChanged
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;

        public abstract Facility Facility { get; set; }
        public abstract DateTimePeriod Period { get; set; }
        public abstract ResidentController ResidentController { get; set; }
        public abstract string Remarks { get; set; }


        public virtual string BookingTitle
        {
            get { return "Book '{0}'".FormatString(Facility.Name); }
        }


        public void SetContext(Facility facility, DateTimePeriod period, ResidentController residentController)
        {
            Facility = RequireArg.NotNull(facility);
            Period = RequireArg.NotNull(period);
            ResidentController = RequireArg.NotNull(residentController);
        }
    }
}
