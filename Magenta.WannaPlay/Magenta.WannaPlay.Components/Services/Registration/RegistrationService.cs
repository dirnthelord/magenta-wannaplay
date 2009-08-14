using System;
using System.Collections.Generic;
using System.Linq;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;

namespace Magenta.WannaPlay.Services.Registration
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IPersistenceRepository _persistenceRepository;

        public RegistrationService(IPersistenceRepository persistenceRepository)
        {
            _persistenceRepository = persistenceRepository;
        }

        #region IRegistrationService Members

        public IEnumerable<GuestRegistration> GetGuestRegistrations(DateTime date, FacilityType facilityType)
        {
            return _persistenceRepository.Search<GuestRegistration>(x => x.TimeIn >= date.RoundDateDown()
               && x.TimeIn <= date.RoundDateUp()
               && x.Facility.FacilityType == facilityType);
        }

        public IEnumerable<ResidentRegistration> GetResidentRegistrations(DateTime date, FacilityType facilityType)
        {
            return _persistenceRepository.Search<ResidentRegistration>(x => x.TimeIn >= date.RoundDateDown()
               && x.TimeIn <= date.RoundDateUp()
               && x.Facility.FacilityType == facilityType);
        }

        public void Register<T>(T record) where T : RegistrationRecord
        {
            _persistenceRepository.Save(record);
        }

        #endregion
    }
}