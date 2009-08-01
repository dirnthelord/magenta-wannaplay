using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Magenta.Shared;
using Magenta.WannaPlay.Domain;
using NHibernate;

namespace Magenta.WannaPlay.Components.Infrustructure.Persistence
{
    public class SampleDatabase
    {
        public Facility TennisCourt1 { get; private set; }

        public Resident ResidentBradPit { get; private set; }

        public DutyGuard DutyGuardRoss { get; private set; }

        public DateTime Today { get; private set; }

        public SampleDatabase(ISession session)
        {
            Today = DateTime.UtcNow.Date;

            CreateFacilities(session);

            CreateResidents();

            CreateDutyGuards();

            CreateBookings(session);
        }

        private void CreateBookings(ISession session)
        {
            var bookingEntry1 = new BookingEntry
                                    {
                                        Facility = TennisCourt1,
                                        BookedByGuard = DutyGuardRoss,
                                        Resident = ResidentBradPit,
                                        BookedAtDateTime = Today.AddHours(6),
                                        Period = new DateTimePeriod(Today.AddHours(10), Today.AddHours(11))
                                    };

            var bookingEntry2 = new BookingEntry
                                    {
                                        Facility = TennisCourt1,
                                        BookedByGuard = DutyGuardRoss,
                                        Resident = ResidentBradPit,
                                        BookedAtDateTime = Today.AddHours(6.5),
                                        Period = new DateTimePeriod(Today.AddHours(13), Today.AddHours(14))
                                    };

            session.Save(bookingEntry1);
            session.Save(bookingEntry2);
        }

        private void CreateDutyGuards()
        {
            DutyGuardRoss = new DutyGuard()
                                {
                                    Name = "Ross"
                                };
        }

        private void CreateResidents()
        {
            ResidentBradPit = new Resident
                                  {
                                      Name = "Brad Pit",
                                      PassCardNumber = "0000",
                                      Unit = new ResidenceUnit { Block = "10", Number = "#99-01" }
                                  };
        }

        private void CreateFacilities(ISession session)
        {
            TennisCourt1 = new Facility { FacilityType = FacilityType.TennisCourt, Name = "Tennis Court 1" };

            session.Save(TennisCourt1);
            session.Save(new Facility { FacilityType = FacilityType.TennisCourt, Name = "Tennis Court 2" });
            session.Save(new Facility { FacilityType = FacilityType.SquashCourt, Name = "Squash Court 1" });
            session.Save(new Facility { FacilityType = FacilityType.SquashCourt, Name = "Squash Court 2" });
        }
    }
}
