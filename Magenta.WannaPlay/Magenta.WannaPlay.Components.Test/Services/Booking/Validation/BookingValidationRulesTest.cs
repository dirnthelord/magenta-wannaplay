﻿using System;
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
        public void BookingIsAvailable()
        {
            // Booked from 10am to 11 am and from 13pm to 14pm
            AssertBookingIsAvailable(9, 10);
            AssertBookingIsAvailable(11, 12);
            AssertBookingIsAvailable(11, 13);
            AssertBookingIsAvailable(12, 13);
            AssertBookingIsAvailable(14, 15);
            AssertBookingIsAvailable(15, 15);
                    }

        [Test]
        public void BookingIsNotAvailable()
        {
            // Booked from 10am to 11 am and from 13pm to 14pm

            AssertBookingIsNotAvailable(9, 11);
            AssertBookingIsNotAvailable(9, 12);
            AssertBookingIsNotAvailable(9, 13);
            AssertBookingIsNotAvailable(9, 14);
            AssertBookingIsNotAvailable(9, 15);

            AssertBookingIsNotAvailable(10, 11);
            AssertBookingIsNotAvailable(10, 12);
            AssertBookingIsNotAvailable(10, 13);
            AssertBookingIsNotAvailable(10, 14);
            AssertBookingIsNotAvailable(10, 15);

            AssertBookingIsNotAvailable(11, 14);
            AssertBookingIsNotAvailable(11, 15);

            AssertBookingIsNotAvailable(12, 14);
            AssertBookingIsNotAvailable(12, 15);
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
