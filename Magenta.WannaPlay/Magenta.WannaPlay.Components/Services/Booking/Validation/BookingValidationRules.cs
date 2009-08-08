using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using Magenta.Shared.Validation;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;
using Magenta.Shared.DesignByContract;

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
                .Required(x => x.BookedByGuard, KnownBookingErrors.DutyGuardIsRequired)

                .Required(x => x.Resident, KnownBookingErrors.ResidentIsRequired)

                .Required(x => x.Resident != null, x => x.Resident.Unit, KnownBookingErrors.ResidenceUnitIsRequired)

                .Required(x => x.Facility, KnownBookingErrors.FacilityIsRequired)

                .Assert(x => x.Resident != null && x.Resident.Unit != null,
                    x => IsEntitledForMoreBooking(x.Resident.Unit, x.Period.From.Date),
                    KnownBookingErrors.ResidentIsNotEntitled)

                .Assert(x => x.Period.From < x.Period.To, KnownBookingErrors.FromLaterThanTo)

                .Assert(x => x.Facility != null, x => IsPeriodAvailable(x.Facility, x.Period), KnownBookingErrors.PeriodIsNotAvailable);
        }

        /// <summary>
        /// 1 hour per day per unit
        /// </summary>
        private bool IsEntitledForMoreBooking(ResidenceUnit residenceUnit, DateTime date)
        {
            var entries = _persistenceRepository.Search<BookingEntry>(
                x => x.Period.From >= date.RoundDateDown() && x.Period.To <= date.RoundDateUp(),
                x => x.Resident.Unit.Block == residenceUnit.Block && x.Resident.Unit.Number == residenceUnit.Number);

            return entries.Count() == 0;
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
