using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.Domain;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class MockBookingService : IBookingService
    {
        public IEnumerable<BookingEntry> GetBookingEntries(DateTimePeriod period, IEnumerable<Facility> facilities)
        {
            //var squashCourtOne = new Facility { FacilityType = FacilityType.SquashCourt, Name = "Court One", Id = 1 };
            //var squashCourtTwo = new Facility { FacilityType = FacilityType.SquashCourt, Name = "Court Two", Id = 2 };
            //var tennisCourtOne = new Facility { FacilityType = FacilityType.TennisCourt, Name = "Court One", Id = 3 };

            var residentOne = new Resident { PassCardNumber = "125", Name = "Konstantin Spirin", Unit = new ResidenceUnit { Block = "143", Number = "12-08" } };
            var residentTwo = new Resident { PassCardNumber = "9875", Name = "Jeffrey Hi", Unit = new ResidenceUnit { Block = "145", Number = "12-08" } };
            var residentThree = new Resident { PassCardNumber = "43", Name = "Nick Bully", Unit = new ResidenceUnit { Block = "143", Number = "3-8" } };

            var guardOne = new DutyGuard { Name = "Chin Hua" };
            var guardTwo = new DutyGuard { Name = "Sick One Keng" };

            yield return new BookingEntry { Period = DateTimePeriod.FromHours(period.From.AddHours(2), 1), Facility = facilities.First(), Resident = residentOne, BookedByGuard = guardOne };
            yield return new BookingEntry { Period = DateTimePeriod.FromHours(period.From.AddHours(4), 2), Facility = facilities.First(), Resident = residentTwo, BookedByGuard = guardOne };
            yield return new BookingEntry { Period = DateTimePeriod.FromHours(period.From.AddHours(9), 1), Facility = facilities.Last(), Resident = residentThree, BookedByGuard = guardTwo };
        }

        public void SaveBookingEntry(BookingEntry bookingSlot)
        {
            throw new NotImplementedException();
        }

        public void CancelBookingEntry(BookingEntry bookingSlot)
        {
            throw new NotImplementedException();
        }
    }
}
