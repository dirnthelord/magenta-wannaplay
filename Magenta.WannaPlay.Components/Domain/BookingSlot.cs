using System;

namespace Magenta.WannaPlay.Domain
{
    public class BookingSlot : Entity
    {
        public virtual TimeSpan From { get; set; }

        /// <summary>
        /// always 1 until we need something else
        /// </summary>
        public virtual int Duration { get; set; }

        public virtual Resident Resident { get; set; }
    }
}