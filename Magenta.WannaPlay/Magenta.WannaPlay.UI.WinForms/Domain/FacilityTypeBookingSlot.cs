﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class FacilityTypeBookingSlot
    {
        [Browsable(false)]
        public virtual DateTimePeriod Period { get { return Booking.Period; } }

        public virtual bool IsEmpty { get { return false; } }

        [Browsable(false)]
        public BookingEntry Booking { get; private set; }

        public FacilityBookingSlot GetFacilityBookingSlot(Facility facility)
        {
            return new EmptyFacilityBookingSlot(Period);
        }

        public FacilityTypeBookingSlot(BookingEntry booking)
        {
            Booking = RequireArg.NotNull(booking);
        }

        protected FacilityTypeBookingSlot()
        {
        }
    }
}
