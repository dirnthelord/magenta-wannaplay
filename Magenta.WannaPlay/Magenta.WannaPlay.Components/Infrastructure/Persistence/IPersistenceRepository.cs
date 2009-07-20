using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using NHibernate;

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

        IEnumerable<T> Search<T>(params Func<T, bool>[] filters);

        void Save<T>(T entity);
    }
}