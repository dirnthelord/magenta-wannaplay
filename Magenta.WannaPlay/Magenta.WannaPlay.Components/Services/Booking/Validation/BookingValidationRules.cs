using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using Magenta.Shared.Validation;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;

namespace Magenta.WannaPlay.Services.Booking.Validation
{
    public class BookingValidationRules : ValidationRules<BookingEntry>
    {
        private readonly IPersistenceRepository _persistenceRepository;

        public BookingValidationRules(IPersistenceRepository persistenceRepository)
        {
            _persistenceRepository = persistenceRepository;

            SetupRules();
        }

        private void SetupRules()
        {
            this
                .Assert(x => x.Period.From < x.Period.To, KnownBookingErrors.FromLaterThanTo)
                .Assert(x => IsPeriodAvailable(x.Facility, x.Period), KnownBookingErrors.PeriodIsNotAvailable);
        }

        private bool IsPeriodAvailable(Facility facility, DateTimePeriod period)
        {
            var entries = _persistenceRepository.Search<BookingEntry>(
                x => x.Facility.Id == facility.Id,
                x => (x.Period.From >= period.From && x.Period.From < period.To) ||
                    (x.Period.To > period.From && x.Period.To <= period.To)
                );

            return entries.Count() == 0;
        }
    }
}
