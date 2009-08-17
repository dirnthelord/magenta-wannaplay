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
        IEnumerable<Facility> GetFacilities();

        IEnumerable<DutyGuard> GetDutyGuards();

        void SaveDutyGuard(DutyGuard dutyGuard);

        /// <summary>
        /// If resident with the passCardNumber does not exist it will be created
        /// </summary>
        Resident GetResident(string passCardNumber);

        /// <summary>
        /// If residence unit with the block\number does not exist it will be created
        /// </summary>
        ResidenceUnit GetResidenceUnit(string unitBlock, string unitNumber);

        /// <summary>
        /// Try to find existing resident in the database and return it filled with passed object data
        /// </summary>
        Resident RectifyResident(Resident resident);
    }
}