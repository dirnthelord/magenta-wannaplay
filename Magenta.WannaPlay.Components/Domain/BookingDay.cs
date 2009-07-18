using System;

namespace Magenta.WannaPlay.Domain
{
    public class BookingDay : Entity
    {
        public virtual DateTime Date { get; set; }

        public virtual Facility Facility { get; set; }
    }
}