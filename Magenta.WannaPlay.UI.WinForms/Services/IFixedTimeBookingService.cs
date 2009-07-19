using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public interface IFixedTimeBookingService
    {
        IEnumerable<FixedTimeBooking> GetBookings(DateTimePeriod period, FacilityType facilityType);
    }
}
