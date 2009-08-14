using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Registration
{
    public interface IRegistrationService
    {
        IEnumerable<GuestRegistration> GetGuestRegistrations(DateTime date, FacilityType facilityType);

        IEnumerable<ResidentRegistration> GetResidentRegistrations(DateTime date, FacilityType facilityType);

        void Register<T>(T record)
            where T : RegistrationRecord;
    }
}
