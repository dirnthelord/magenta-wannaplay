using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Magenta.WannaPlay.Domain;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    [TestFixture]
    public class GranularBookingScheduleGeneratorTests
    {
        [Test]
        [Ignore("Fails")]
        public void GenerateSchedule()
        {
            var from = new DateTime(2009, 07, 20);

            var bookings = new [] 
            { 
                new BookingEntry { Period = DateTimePeriod.FromHours(from.AddHours(1), 1) },
                new BookingEntry { Period = DateTimePeriod.FromHours(from.AddHours(2), 2) },
                new BookingEntry { Period = DateTimePeriod.FromHours(from.AddHours(5), 3) },
            };

            var sheduleGenerator = new BookingScheduleGenerator(bookings, TimeSpan.FromHours(1));

            var schedule = sheduleGenerator.GenerateSchedule(DateTimePeriod.FromHours(from, 9)).ToList();

            schedule[0].IsEmpty.AssertIsTrue();
            schedule[0].Booking.Period.AssertIsEqual(DateTimePeriod.FromHours(from, 1));

            Assert.Fail();
        }
    }
}
