using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class GranularScheduleFacilityTypeBookingSlot
    {
        [Browsable(false)]
        public virtual DateTimePeriod Period { get { return Booking.Period; } }

        public virtual bool IsEmpty { get { return false; } }

        [Browsable(false)]
        public BookingEntry Booking { get; private set; }

        public GranularScheduleFacilityTypeBookingSlot(BookingEntry booking)
        {
            Booking = RequireArg.NotNull(booking);
        }

        protected GranularScheduleFacilityTypeBookingSlot()
        {
        }
    }
}
