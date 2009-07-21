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
            var residents = _persistenceRepository
                .Search<Resident>(r => r.PassCardNumber == passCardNumber)
                .ToList();

            if(residents.Count == 0)
                return new Resident { PassCardNumber = passCardNumber };

            return residents[0];
        }

        public ResidenceUnit GetResidenceUnit(string unitBlock, string unitNumber)
        {
            var residenceUnits = _persistenceRepository
                .Search<ResidenceUnit>(u => u.Block == unitBlock && u.Number == unitNumber)
                .ToList();

            if (residenceUnits.Count == 0)
                return new ResidenceUnit { Block = unitBlock, Number = unitNumber };

            return residenceUnits[0];
        }

        #endregion
    }
}