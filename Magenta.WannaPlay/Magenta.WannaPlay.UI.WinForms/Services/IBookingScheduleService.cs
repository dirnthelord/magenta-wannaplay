using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public interface IBookingScheduleService
    {
        IEnumerable<FacilityBookingSlot> GetBookings(DateTimePeriod period, Facility facilityType);
    }
}
