﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class GranularScheduleBookingService : IGranularScheduleBookingService
    {
        public IBookingService BookingService { get; private set; }

        // TODO: Inject via configuration service
        TimeSpan Granularity { get; set; }

        bool IsWithinActivityWindow(DateTime date)
        {
            return date.Hour >= 7 && date.Hour <= 22;
        }

        public GranularScheduleBookingService(IBookingService bookingService)
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

        public IEnumerable<GranularScheduleFacilityBookingSlot> GetBookings(DateTimePeriod fullPeriod, Facility facility)
        {
            var facilityTypeBookings = BookingService.GetBookingEntries(fullPeriod, facility.FacilityType);
            var facilityBookings = facilityTypeBookings.Where(b => b.Facility == facility);

            return new GranularBookingScheduleGenerator(facilityBookings, Granularity).GenerateSchedule(fullPeriod);
        }
    }
}