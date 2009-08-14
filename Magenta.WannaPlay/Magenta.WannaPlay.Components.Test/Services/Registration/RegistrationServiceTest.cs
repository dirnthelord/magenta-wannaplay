using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Testing.NHibernate;
using Magenta.WannaPlay.Components.Infrustructure.Persistence;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;
using Magenta.WannaPlay.Services.Registration;
using NUnit.Framework;

namespace Magenta.WannaPlay.Components.Services.Registration
{
    public class RegistrationServiceTest
        : NHibernateTest<RegistrationService, SqLiteInMemoryPersister, WannaPlayPersistenceModel> 
    {
        SampleCondo _condo;

        protected override RegistrationService CreateTarget()
        {
            return new RegistrationService(new PersistenceRepository(Session));
        }

        protected override void SetupTestContext()
        {
            _condo = new SampleCondo(Session);
        }

        [Test]
        public void GetGuestRegistrations()
        {
            Target.GetGuestRegistrations(_condo.Today, FacilityType.SwimmingPool)
                .Select(x => x.GuestName).AssertSequenceEqual("Vasya");
        }

        [Test]
        public void GetResidentRegistrations()
        {
            Target.GetResidentRegistrations(_condo.Today, FacilityType.Gymnasium)
                .Select(x => x.Resident.Name).AssertSequenceEqual(_condo.ResidentGeorgeCarlin.Name);
        }
    }
}
