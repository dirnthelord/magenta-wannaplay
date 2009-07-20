using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class MockResidenceManager  : IResidenceManager
    {
        public IEnumerable<Facility> GetTennisCourts()
        {
            yield return new Facility { FacilityType = FacilityType.TennisCourt, Name = "Court One", Id = 1 };
            yield return new Facility { FacilityType = FacilityType.TennisCourt, Name = "Court Two", Id = 2 };
        }

        public IEnumerable<Facility> GetSquashCourts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DutyGuard> GetDutyGuards()
        {
            throw new NotImplementedException();
        }

        public void CreateDutyGuard(DutyGuard dutyGuard)
        {
            throw new NotImplementedException();
        }

        public Resident GetResident(string number)
        {
            throw new NotImplementedException();
        }

        #region IResidenceManager Members


        public ResidenceUnit GetResidenceUnit(string unitBlock, string unitNumber)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
