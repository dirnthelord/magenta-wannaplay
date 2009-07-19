using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Testing;
using Magenta.Shared.Testing.NHibernate;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.NHibernate;
using NUnit.Framework;

namespace Magenta.WannaPlay.Components.Domain
{
    [TestFixture]
    public class BookingSlotTest : NHibernateMappingTest<SqLiteInMemoryPersister, WannaPlayPersistenceModel>
    {
        private Resident _resident;
        private Facility _facility;
        private DutyGuard _dutyGuard;

        protected override void SetupTestContext()
        {
            _resident = new Resident
                             {
                                 Name = "John Black",
                                 PassCardNumber = "1234",
                                 Address = new ResidenceAddress {Block = "100", Unit = "#13-01"}
                             };

            _facility = new Facility
                            {
                                Name = "Tennis Court 1",
                                FacilityType = FacilityType.TennisCourt
                            };

            _dutyGuard = new DutyGuard
                             {
                                 Name = "Ross"
                             };

            Session.Save(_resident);
            Session.Save(_facility);
            Session.Save(_dutyGuard);
        }

        [Test]
        public void InsertSelect()
        {
            var now = DateTime.UtcNow.RoundToSeconds();

            new PersistenceSpecification<BookingEntry>(Session)
                .CheckProperty(x => x.FromTime, now.AddDays(1))
                .CheckProperty(x => x.ToTime, now.AddDays(1).AddHours(1))
                .CheckProperty(x => x.Resident, _resident)
                .CheckProperty(x => x.BookedByGuard, _dutyGuard)
                .CheckProperty(x => x.Facility, _facility)
                .CheckProperty(x => x.BookedAt, now)
                .VerifyTheMappings();
        }
    }
}
