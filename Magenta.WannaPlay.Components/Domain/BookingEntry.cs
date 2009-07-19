using System;
using Magenta.Shared;

namespace Magenta.WannaPlay.Domain
{
    public class BookingEntry : Entity
    {
        public virtual Facility Facility { get; set; }

        public virtual Resident Resident { get; set; }

        public virtual DutyGuard BookedByGuard { get; set; }

        public virtual DateTime BookedAtDateTime { get; set; }

        public virtual DateTimePeriod Period { get; set; }
    }
}