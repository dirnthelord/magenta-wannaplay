using System;
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

        public BookingSlot GetBookingDay(DateTime date)
        {
            return null;
        }

        public void SaveBookingDay(BookingSlot bookingDay)
        {
            _validator.Validate(bookingDay);
        }

        #endregion
    }
}