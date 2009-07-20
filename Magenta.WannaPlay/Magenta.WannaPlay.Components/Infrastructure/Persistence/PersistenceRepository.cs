using System;
using System.Collections.Generic;
using System.Linq;
using Magenta.WannaPlay.Domain;
using NHibernate;
using NHibernate.Linq;

namespace Magenta.WannaPlay.Infrastructure.Persistence
{
    public class PersistenceRepository : IPersistenceRepository
    {
        private readonly ISession _session;

        public PersistenceRepository(ISession session)
        {
            _session = session;
        }

        #region IPersistenceRepository Members

        public IEnumerable<BookingEntry> LoadBookingEntries(DateTime from, DateTime to, FacilityType facilityType)
        {
            return _session.Linq<BookingEntry>()
                .Where(booking => booking.Period.From >= from.RoundDateDown()
                    && booking.Period.To <= to.RoundDateUp()
                    && booking.Facility.FacilityType == facilityType)
                .ToList();
        }

        public void SaveBookingEntry(BookingEntry bookingEntry)
        {
            _session.Save(bookingEntry);
        }

        public IEnumerable<Facility> LoadFacilities()
        {
            return _session.Linq<Facility>().ToList();
        }

        public IEnumerable<DutyGuard> LoadDutyGuards()
        {
            return _session.Linq<DutyGuard>().ToList();
        }

        public void SaveDutyGuard(DutyGuard dutyGuard)
        {
            _session.Save(dutyGuard);
        }

        public Resident LoadResident(string number)
        {
            return _session.Linq<Resident>().Single(r => r.PassCardNumber == number);
        }

        public void Save<T>(T entity)
        {
            _session.Save(entity);
        }

        #endregion
    }
}