using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Testing;
using Magenta.Shared.Testing.NHibernate;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;
using NUnit.Framework;

namespace Magenta.WannaPlay.Components.Domain
{
    [TestFixture]
    public class GuestRegistrationTest : NHibernateMappingTest<SqLiteInMemoryPersister, WannaPlayPersistenceModel>
    {
        private Resident _resident;
        private Facility _facility;

        protected override void SetupTestContext()
        {
            _resident = new Resident
            {
                Name = "John Black",
                PassCardNumber = "1234",
                Unit = new ResidenceUnit { Block = "100", Number = "#13-01" }
            };

            _facility = new Facility
            {
                Name = "Swimming pool",
                FacilityType = FacilityType.SwimmingPool
            };

            Session.Save(_resident);
            Session.Save(_facility);            
        }

        [Test]
        public void InsertSelect()
        {
            var now = DateTime.UtcNow.RoundToSeconds();

            new PersistenceSpecification<GuestRegistration>(Session)                
                .CheckProperty(x => x.Resident, _resident)                
                .CheckProperty(x => x.Facility, _facility)
                .CheckProperty(x => x.TimeIn, now)
                .CheckProperty(x => x.GuestName, "Michael")
                .CheckProperty(x => x.Remarks, "remarks1")                
                .VerifyTheMappings();
        }
    }
}
