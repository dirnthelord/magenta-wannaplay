using System;

namespace Magenta.WannaPlay.Domain
{
    public class BookingSlot : Entity
    {
        public virtual Facility Facility { get; set; }

        public virtual DateTime From { get; set; }

        public virtual DateTime To { get; set; }

        public virtual Resident Resident { get; set; }

        public virtual DutyGuard BookedBy { get; set; }
    }
}