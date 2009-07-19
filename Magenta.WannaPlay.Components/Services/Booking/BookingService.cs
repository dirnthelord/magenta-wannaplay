using System;
using System.Collections.Generic;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;
using Magenta.Shared;

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

        public IEnumerable<BookingEntry> GetBookingEntries(DateTimePeriod period, FacilityType facilityType)
        {
            return null;
        }

        public void SaveBookingEntry(BookingEntry bookingDay)
        {
            _validator.Validate(bookingDay);
        }

        public void CancelBookingEntry(BookingEntry bookingEntry)
        {
            
        }

        #endregion
    }
}