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
        IEnumerable<BookingSlot> LoadBookingSlots(DateTime from, DateTime to, FacilityType facilityType);

        void SaveBookingSlot(BookingSlot bookingSlot);

        IEnumerable<Facility> LoadFacilities();

        IEnumerable<DutyGuard> LoadDutyGuards();

        void SaveDutyGuard(DutyGuard dutyGuard);

        Resident LoadResident(string number);
    }
}