using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class FixedTimeBookingService : IFixedTimeBookingService
    {
        public IBookingService BookingService { get; private set; }

        // TODO: Inject via service
        TimeSpan Granularity { get; set; }

        bool IsWithinActivityWindow(DateTime date)
        {
            return date.Hour >= 7 && date.Hour <= 22;
        }

        public FixedTimeBookingService(IBookingService bookingService)
        {
            BookingService = RequireArg.NotNull(bookingService);
            Granularity = TimeSpan.FromHours(1.0);
        }

        IEnumerable<DateTimePeriod> GetSheduleSheetPeriods(DateTimePeriod fullPeriod)
        {
            for (var from = fullPeriod.From; from <= fullPeriod.To; from = from.Add(Granularity))
            {
                var to = from.Add(Granularity);

                if (IsWithinActivityWindow(from) && IsWithinActivityWindow(to))
                    yield return new DateTimePeriod(from, to);
            }
        }

        public IEnumerable<FixedTimeBooking> GetBookings(DateTimePeriod fullPeriod, FacilityType facilityType)
        {
            var periods = GetSheduleSheetPeriods(fullPeriod);
            var bookings = BookingService.GetBookingSlots(fullPeriod.From, fullPeriod.To, facilityType).ToList();

            return periods.Select(p => CreateFixedTimeBooking(bookings, p));
        }

        private FixedTimeBooking CreateFixedTimeBooking(List<BookingSlot> bookings, DateTimePeriod period)
        {
            var booking = bookings.Where(b => b.FromTime >= period.From && b.ToTime <= period.To).SingleOrDefault();

            if (booking != null)
                return FixedTimeBooking.FromBooking(booking);

            return new FixedTimeBooking { Period = "not set"  };
        }
    }
}
