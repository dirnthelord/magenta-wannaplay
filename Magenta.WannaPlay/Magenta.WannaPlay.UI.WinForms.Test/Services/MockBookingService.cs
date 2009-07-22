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
            var residents = new[]
            {
                new Resident { PassCardNumber = "125", Name = "Konstantin Spirin", Unit = new ResidenceUnit { Block = "143", Number = "12-08" } },
                new Resident { PassCardNumber = "9875", Name = "Jeffrey Hi", Unit = new ResidenceUnit { Block = "145", Number = "12-08" } },
                new Resident { PassCardNumber = "43", Name = "Nick Bully", Unit = new ResidenceUnit { Block = "143", Number = "3-8" } },
            };

            var guards = new[] 
            {
                new DutyGuard { Name = "Chin Hua" },
                new DutyGuard { Name = "Sick One Keng" }
            };

            Random random = new Random(period.From.DayOfYear + period.From.Year * 366);

            foreach (var facility in facilities)
            {
                var lastEntry = new BookingEntry { Period = DateTimePeriod.FromHours(period.From, 0) };

                for (var hour = period.From; hour < period.To; hour = hour.AddHours(1))
                {
                    var entry = new BookingEntry
                    {
                        Period = DateTimePeriod.FromHours(lastEntry.Period.To.AddHours(random.Next(4)), random.Next(3)),
                        Facility = facility,
                        Resident = random.NextItem(residents),
                        BookedByGuard = random.NextItem(guards),
                    };

                    yield return entry;

                    lastEntry = entry;
                }
            }
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
