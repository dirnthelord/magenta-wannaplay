using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    public class BookingEntryUI
    {
        [Browsable(false)]
        public virtual DateTimePeriod Period { get { return Booking.Period; } }

        [DisplayName("Facility")]
        public virtual string FacilityName { get { return Booking.Facility.Name; } }

        [DisplayName("Period")]
        public virtual string PeriodString { get { return string.Format("{0:h tt} - {1:h tt}", Period.From, Period.To); } }

        [DisplayName("Booked By Guard")]
        public virtual string BookedByGuard { get { return Booking.BookedByGuard == null ? "<unknown>" : Booking.BookedByGuard.Name; } }

        [DisplayName("Block & Number")]
        public virtual string ResidentAddress { get { return string.Format("{0}, #{1}", Booking.Resident.Unit.Block, Booking.Resident.Unit.Number); } }

        [DisplayName("Resident Name")]
        public virtual string ResidentName { get { return Booking.Resident.Name; } }

        [DisplayName("Resident Pass Number")]
        public virtual string ResidentPassNumber { get { return Booking.Resident.PassCardNumber; } }

        [Browsable(false)]
        public virtual bool IsEmpty { get { return false; } }

        [Browsable(false)]
        public BookingEntry Booking { get; private set; }

        public BookingEntryUI(BookingEntry booking)
        {
            Booking = RequireArg.NotNull(booking);
        }

        protected BookingEntryUI()
        {
        }
    }
}
