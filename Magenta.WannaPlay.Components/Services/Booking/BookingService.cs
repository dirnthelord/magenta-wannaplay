using System;
using System.Collections.Generic;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;

namespace Magenta.WannaPlay.Services.Booking
{
    public class BookingService : IBookingService
    {
        private readonly IPersistenceRepository _persistenceRepository;
        private readonly IBookingValidator _validator;

        public BookingService(IPersistenceRepository persistenceRepository, IBookingValidator validator)
        {
            _persistenceRepository = persistenceRepository;
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