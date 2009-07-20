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
        IEnumerable<BookingEntry> GetBookingEntries(DateTimePeriod period, FacilityType facilityType);

        /// <summary>
        /// Validates booking slot according to the current rules and saved it persistence storage
        /// </summary>
        ///<exception cref="BookingValidationException"></exception>
        void SaveBookingEntry(BookingEntry bookingSlot);

        void CancelBookingEntry(BookingEntry bookingSlot);
    }
}
