using System;
using System.Collections.Generic;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Booking
{
    public class BookingService : IBookingService
    {
        private readonly IBookingValidator _validator;

        public BookingService(IBookingValidator validator)
        {
            _validator = validator;
        }

        #region IBookingService Members

        public IEnumerable<BookingSlot> GetBookingSlots(DateTime from, DateTime to, FacilityType facilityType)
        {
            return null;
        }

        public void SaveBookingSlot(BookingSlot bookingDay)
        {
            _validator.Validate(bookingDay);
        }

        public void CancelBookingSlot(BookingSlot bookingSlot)
        {
            
        }

        #endregion
    }
}