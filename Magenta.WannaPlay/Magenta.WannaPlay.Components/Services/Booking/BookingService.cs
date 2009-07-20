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
            return _persistenceRepository.Search<BookingEntry>(e => e.Period.From >= period.From.RoundDateDown()
                    && e.Period.To <= period.To.RoundDateUp()
                   && e.Facility.FacilityType == facilityType);
        }

        public void SaveBookingEntry(BookingEntry bookingEntry)
        {
            _validator.Validate(bookingEntry);

            _persistenceRepository.Save(bookingEntry);
        }

        public void CancelBookingEntry(BookingEntry bookingEntry)
        {
            _persistenceRepository.Delete(bookingEntry);
        }

        #endregion
    }
}