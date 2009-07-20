using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Infrastructure.Persistence
{
    public interface IPersistenceRepository
    {
        IEnumerable<BookingEntry> LoadBookingEntries(DateTime from, DateTime to, FacilityType facilityType);

        void SaveBookingEntry(BookingEntry bookingEntry);

        IEnumerable<Facility> LoadFacilities();

        IEnumerable<DutyGuard> LoadDutyGuards();

        void SaveDutyGuard(DutyGuard dutyGuard);

        Resident LoadResident(string number);
    }
}