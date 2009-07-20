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
            throw new NotImplementedException();
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
    }
}
