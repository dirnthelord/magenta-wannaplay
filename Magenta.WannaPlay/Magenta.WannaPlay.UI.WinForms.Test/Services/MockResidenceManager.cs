using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class MockResidenceManager : IResidenceManager
    {
        public ResidenceUnit GetResidenceUnit(string unitBlock, string unitNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Facility> GetFacilities()
        {
            yield return new Facility { FacilityType = FacilityType.TennisCourt, Name = "Court One", Id = 1 };
            yield return new Facility { FacilityType = FacilityType.TennisCourt, Name = "Court Two", Id = 2 };

            yield return new Facility { FacilityType = FacilityType.SquashCourt, Name = "Court Two", Id = 3 };
            yield return new Facility { FacilityType = FacilityType.SquashCourt, Name = "Court Two", Id = 4 };
        }

        public IEnumerable<DutyGuard> GetDutyGuards()
        {
            throw new NotImplementedException();
        }

        public void SaveDutyGuard(DutyGuard dutyGuard)
        {
            throw new NotImplementedException();
        }

        public Resident GetResident(string passCardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
