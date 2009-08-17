using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    // TODO: Remove this mock class
    public class MockResidenceManager : IResidenceManager
    {
        public ResidenceUnit GetResidenceUnit(string unitBlock, string unitNumber)
        {
            return new ResidenceUnit { Block = unitBlock, Number = unitNumber };
        }

        public IEnumerable<Facility> GetFacilities()
        {
            yield return new Facility { FacilityType = FacilityType.TennisCourt, Name = "Tennis Court One", Id = 1 };
            yield return new Facility { FacilityType = FacilityType.TennisCourt, Name = "Tennis Court Two", Id = 2 };

            yield return new Facility { FacilityType = FacilityType.SquashCourt, Name = "Squash Court One", Id = 3 };
            yield return new Facility { FacilityType = FacilityType.SquashCourt, Name = "Squash Court Two", Id = 4 };
        }

        public IEnumerable<DutyGuard> GetDutyGuards()
        {
            yield return new DutyGuard { Id = 1, Name = "Harry" };
            yield return new DutyGuard { Id = 2, Name = "Simon" };
            yield return new DutyGuard { Id = 3, Name = "Vinay" };
        }

        public void SaveDutyGuard(DutyGuard dutyGuard)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Resident> GetResidents()
        {
            yield return new Resident { Id = 1, Name = "Oliver", PassCardNumber = "999", Unit = new ResidenceUnit { Id = 1, Block = "143", Number = "#12-08" } };
            yield return new Resident { Id = 1, Name = "Michael", PassCardNumber = "1", Unit = new ResidenceUnit { Id = 2, Block = "34", Number = "#98" } };
            yield return new Resident { Id = 1, Name = "Glen", PassCardNumber = "9999", Unit = new ResidenceUnit { Id = 3, Block = "124", Number = "#13-02" } };
            yield return new Resident { Id = 1, Name = "Andrey", PassCardNumber = "2", Unit = new ResidenceUnit { Id = 4, Block = "9034A", Number = "#02-03" } };
        }

        public Resident GetResident(string passCardNumber)
        {
            return GetResidents().Where(r => r.PassCardNumber == passCardNumber).FirstOrDefault();
        }

        #region IResidenceManager Members


        public Resident RectifyResident(Resident resident)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
