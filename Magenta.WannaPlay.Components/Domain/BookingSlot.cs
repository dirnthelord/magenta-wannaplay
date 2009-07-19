using System;

namespace Magenta.WannaPlay.Domain
{
    public class BookingSlot : Entity
    {
        public virtual Facility Facility { get; set; }

        public virtual DateTime FromTime { get; set; }

        public virtual DateTime ToTime { get; set; }

        public virtual Resident Resident { get; set; }

        public virtual DutyGuard BookedByGuard { get; set; }

        public virtual DateTime BookedAt { get; set; }
    }
}