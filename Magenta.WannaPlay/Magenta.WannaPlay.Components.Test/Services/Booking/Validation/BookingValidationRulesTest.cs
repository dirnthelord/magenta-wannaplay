using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using Magenta.Shared.Testing.NHibernate;
using Magenta.WannaPlay.Components.Infrustructure.Persistence;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;
using Magenta.WannaPlay.Services.Booking.Validation;
using NUnit.Framework;

namespace Magenta.WannaPlay.Components.Services.Booking.Validation
{
    [TestFixture]
    public class BookingValidationRulesTest
        : NHibernateTest<BookingValidationRules, SqLiteInMemoryPersister, WannaPlayPersistenceModel> 
    {
        SampleDatabase _database;

        protected override BookingValidationRules CreateTarget()
        {
            return new BookingValidationRules(new PersistenceRepository(Session));
        }

        protected override void SetupTestContext()
        {
            _database = new SampleDatabase(Session);
        }

        [Test]
        public void BooksNotAvailable()
        {
            AssertBookingIsAvailable(11, 12);

            AssertBookingIsNotAvailable(12, 13);
            AssertBookingIsNotAvailable(11, 13);

            AssertBookingIsNotAvailable(10, 11);
            AssertBookingIsNotAvailable(10, 13);

            AssertBookingIsAvailable(9, 10);
            AssertBookingIsNotAvailable(9, 11);
            AssertBookingIsNotAvailable(9, 13);
        }

        private void AssertBookingIsAvailable(int from, int to)
        {
            BookingEntry entry = CreateBooking(from, to);

            Target.Validate(entry).Count().AssertIsEqual(0);
        }

        private void AssertBookingIsNotAvailable(int from, int to)
        {
            BookingEntry entry = CreateBooking(from, to);

            Target.Validate(entry).Select(f => f.ErrorId).AssertSequenceEqual(KnownBookingErrors.PeriodIsNotAvailable);
        }

        private BookingEntry CreateBooking(int from, int to)
        {
            return new BookingEntry
                       {
                           Facility = _database.TennisCourt1,
                           BookedByGuard = _database.DutyGuardRoss,
                           Resident = _database.ResidentBradPit,
                           Period = new DateTimePeriod(_database.Today.AddHours(from), _database.Today.AddHours(to))
                       };
        }
    }
}
