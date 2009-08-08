using System;
using Magenta.Shared;

namespace Magenta.WannaPlay.Domain
{
    public class BookingEntry : Entity
    {
        public BookingEntry()
        {
            Remarks = "";
            // TODO: Remove reference to time
            BookedAtDateTime = DateTime.UtcNow;
        }

        public virtual Facility Facility { get; set; }

        public virtual Resident Resident { get; set; }

        public virtual DutyGuard BookedByGuard { get; set; }

        public virtual DateTime BookedAtDateTime { get; set; }

        public virtual DateTimePeriod Period { get; set; }

        public virtual string Remarks { get; set; }

        public override string ToString()
        {
            return string.Format("{0} by {1}", Period, Resident);
        }
    }
}