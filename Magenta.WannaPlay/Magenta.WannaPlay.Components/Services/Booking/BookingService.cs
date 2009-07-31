using System;
using System.Collections.Generic;
using Magenta.Shared.Validation;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;
using Magenta.Shared;
using System.Linq;

namespace Magenta.WannaPlay.Services.Booking
{
    public class BookingService : IBookingService
    {
        private readonly IPersistenceRepository _persistenceRepository;
        private readonly IValidationRules<BookingEntry> _rules;

        public BookingService(IPersistenceRepository persistenceRepository, IValidationRules<BookingEntry> rules)
        {
            _persistenceRepository = persistenceRepository;
            _rules = rules;
        }

        #region IBookingService Members

        public IEnumerable<BookingEntry> GetBookingEntries(DateTimePeriod period, IEnumerable<Facility> facilities)
        {
            return _persistenceRepository.Search<BookingEntry>(e => e.Period.From >= period.From.RoundDateDown()
                    && e.Period.To <= period.To.RoundDateUp()
                   && facilities.Contains(e.Facility));
        }

        public void SaveBookingEntry(BookingEntry bookingEntry)
        {
            var failures = _rules.Validate(bookingEntry);

            if (failures.Count() > 0)
                throw new ValidationException(failures);

            _persistenceRepository.Save(bookingEntry);
        }

        public void CancelBookingEntry(BookingEntry bookingEntry)
        {
            _persistenceRepository.Delete(bookingEntry);
        }

        #endregion
    }
}