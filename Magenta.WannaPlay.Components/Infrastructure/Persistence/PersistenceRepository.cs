using System;
using System.Collections.Generic;
using Magenta.WannaPlay.Domain;
using NHibernate;

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

        public IEnumerable<BookingSlot> LoadBookingSlots(DateTime from, DateTime to, FacilityType facilityType)
        {
            return null;
        }

        public void SaveBookingSlot(BookingSlot bookingSlot)
        {
            
        }

        public IEnumerable<Facility> LoadFacilities()
        {
            return null;
        }

        public IEnumerable<DutyGuard> LoadDutyGuards()
        {
            return null;
        }

        public void SaveDutyGuard(DutyGuard dutyGuard)
        {
            
        }

        public Resident LoadResident(int number)
        {
            return null;
        }

        #endregion
    }
}