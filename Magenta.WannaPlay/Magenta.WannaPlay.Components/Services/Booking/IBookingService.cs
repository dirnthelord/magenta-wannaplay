using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using Magenta.Shared;

namespace Magenta.WannaPlay.Services.Booking
{
    public interface IBookingService
    {
        IEnumerable<BookingEntry> GetBookingEntries(DateTimePeriod period, IEnumerable<Facility> facilities);

        /// <summary>
        /// Persists new booking entry
        /// </summary>
        // TODO: Change interface to batch-style
        void AddBooking(BookingEntry bookingSlot);

        // TODO: Change interface to batch-style
        void CancelBooking(BookingEntry bookingSlot);
    }
}
