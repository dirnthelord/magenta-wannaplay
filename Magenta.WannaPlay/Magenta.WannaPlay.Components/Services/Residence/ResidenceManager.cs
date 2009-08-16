using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Facility> GetFacilities()
        {
            return _persistenceRepository.Search<Facility>();
        }

        public IEnumerable<DutyGuard> GetDutyGuards()
        {
            return _persistenceRepository.Search<DutyGuard>();
        }

        public void SaveDutyGuard(DutyGuard dutyGuard)
        {
            _persistenceRepository.Save(dutyGuard);
        }

        public Resident GetResident(string passCardNumber)
        {
            // Null when no resident found!
            return _persistenceRepository
                .Search<Resident>(r => r.PassCardNumber == passCardNumber)
                .SingleOrDefault();
        }

        public ResidenceUnit GetResidenceUnit(string unitBlock, string unitNumber)
        {
            // Null when no unit found!
            return _persistenceRepository
                .Search<ResidenceUnit>(u => u.Block == unitBlock && u.Number == unitNumber)
                .SingleOrDefault();
        }

        #endregion
    }
}