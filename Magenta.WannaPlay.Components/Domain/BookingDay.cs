using System;
using System.Collections.Generic;

namespace Magenta.WannaPlay.Domain
{
    public class BookingDay : Entity
    {
        public virtual DateTime Date { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual IList<BookingSlot> Slots { get; set; }
    }
}