using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class MockBookingService : IBookingService
    {
        public IEnumerable<BookingSlot> GetBookingSlots(DateTime from, DateTime to, FacilityType facilityType)
        {
            var squashCourtOne = new Facility { FacilityType = FacilityType.SquashCourt, Name = "Court One" };
            var squashCourtTwo = new Facility { FacilityType = FacilityType.SquashCourt, Name = "Court Two" };
            var tennisCourtOne = new Facility { FacilityType = FacilityType.TennisCourt, Name = "Court One" };

            var residentOne = new Resident { Number = "125", Name = "Konstantin Spirin", Address = new ResidenceAddress { Block = "143", Unit = "12-08" } };
            var residentTwo = new Resident { Number = "9875", Name = "Jeffrey Hi", Address = new ResidenceAddress { Block = "145", Unit = "12-08" } };
            var residentThree = new Resident { Number = "43", Name = "Nick Bully", Address = new ResidenceAddress { Block = "143", Unit = "3-8" } };

            var guardOne = new DutyGuard { Name = "Chin Hua" };
            var guardTwo = new DutyGuard { Name = "Sick One Keng" };

            yield return new BookingSlot { FromTime = from.AddHours(2), ToTime = from.AddHours(3), Facility = squashCourtOne, Resident = residentOne, BookedBy = guardOne };
            yield return new BookingSlot { FromTime = from.AddHours(4), ToTime = from.AddHours(6), Facility = tennisCourtOne, Resident = residentTwo, BookedBy = guardOne };
            yield return new BookingSlot { FromTime = from.AddHours(9), ToTime = from.AddHours(10), Facility = squashCourtOne, Resident = residentThree, BookedBy = guardTwo };
        }

        public void SaveBookingSlot(BookingSlot bookingSlot)
        {
            throw new NotImplementedException();
        }

        public void CancelBookingSlot(BookingSlot bookingSlot)
        {
            throw new NotImplementedException();
        }
    }
}
