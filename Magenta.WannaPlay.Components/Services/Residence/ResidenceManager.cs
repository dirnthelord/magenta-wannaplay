using System.Collections.Generic;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;

namespace Magenta.WannaPlay.Services.Residence
{
    public class ResidenceManager : IResidenceManager
    {
        private readonly IPersistenceRepository _persistenceRepository;

        public ResidenceManager(IPersistenceRepository persistenceRepository)
        {
            _persistenceRepository = persistenceRepository;
        }

        #region IResidenceManager Members

        public IEnumerable<Facility> GetBookableFacilities()
        {
            return null;
        }

        public IEnumerable<DutyGuard> GetDutyGuards()
        {
            return null;
        }

        public void CreateDutyGuard(DutyGuard dutyGuard)
        {
            
        }

        public Resident GetResident(int number)
        {
            return null;
        }

        #endregion
    }
}