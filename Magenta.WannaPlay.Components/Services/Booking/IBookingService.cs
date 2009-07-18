using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Booking
{
    public interface IBookingService
    {
        IEnumerable<BookingSlot> GetBookingSlots(DateTime from, DateTime to, FacilityType facilityType);

        /// <summary>
        /// Validates booking slot according to the current rules and saved it persistence storage
        /// </summary>
        ///<exception cref="BookingValidationException"></exception>
        void SaveBookingSlot(BookingSlot bookingSlot);

        void CancelBookingSlot(BookingSlot bookingSlot);
    }
}
