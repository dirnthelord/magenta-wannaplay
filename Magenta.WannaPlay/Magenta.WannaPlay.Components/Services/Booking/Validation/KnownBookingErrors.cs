using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Services.Booking.Validation
{
    public static class KnownBookingErrors
    {
        public static readonly string FromLaterThanTo = "error.from.laterthanto";

        public static readonly string PeriodIsNotAvailable = "error.period.isnotavaileble";
    }
}
