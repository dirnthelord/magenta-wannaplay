using System.Collections.Generic;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Residence
{
    public class ResidenceManager : IResidenceManager
    {
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