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

        public IEnumerable<BookingEntry> LoadBookingSlots(DateTime from, DateTime to, FacilityType facilityType)
        {
            return _session.Linq<BookingEntry>()
                .Where(slot => slot.Period.From >= from.RoundDateDown()
                    && slot.Period.To <= to.RoundDateUp()
                    && slot.Facility.FacilityType == facilityType)
                .ToList();
        }

        public void SaveBookingSlot(BookingEntry bookingSlot)
        {
            _session.Save(bookingSlot);
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

        #endregion
    }
}