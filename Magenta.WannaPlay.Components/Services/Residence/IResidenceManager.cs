using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Residence
{
    public interface IResidenceManager
    {
        IEnumerable<Facility> GetTennisCourts();

        IEnumerable<Facility> GetSquashCourts();

        IEnumerable<DutyGuard> GetDutyGuards();

        void CreateDutyGuard(DutyGuard dutyGuard);

        /// <summary>
        /// If resident with the number does not exist it will be created
        /// </summary>
        Resident GetResident(int number);
    }
}