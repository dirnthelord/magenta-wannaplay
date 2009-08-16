using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class BookingScheduleGenerator
    {
        readonly List<BookingEntry> _bookings;

        public BookingScheduleGenerator(IEnumerable<BookingEntry> bookings, TimeSpan granularity)
        {
            _bookings = RequireArg.NotNull(bookings).ToList();
            Granularity = granularity;
        }

        TimeSpan Granularity { get; set; }

        public IEnumerable<BookingSlot> GenerateSchedule(DateTimePeriod fullPeriod)
        {
            // TODO: Sort bookings by date
            // TODO: Make sure bookings do not intersect

            int nextBookingIndex = 0;
            DateTime currentFrom = fullPeriod.From;

            while (currentFrom < fullPeriod.To)
            {
                BookingEntry currentBooking = null;

                if (nextBookingIndex < _bookings.Count)
                {
                    var nextBooking = _bookings[nextBookingIndex];

                    if (nextBooking.Period.From <= currentFrom)
                    {
                        currentBooking = nextBooking;
                        nextBookingIndex++;
                    }
                }

                throw new NotImplementedException();
                yield break;

                //var bookingSlot =
                //    currentBooking != null
                //    ? new BookingEntryUI(currentBooking)
                //    : new EmptyBookingEntryUI(new DateTimePeriod(currentFrom, currentFrom.Add(Granularity)));

                //yield return bookingSlot;

                //currentFrom = bookingSlot.Period.To;
            }
        }
    }
}
