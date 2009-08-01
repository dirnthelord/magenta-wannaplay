using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Services.Booking.Validation
{
    public static class KnownBookingErrors
    {
        public static readonly string FromLaterThanTo = "From should be less than To";

        public static readonly string PeriodIsNotAvailable = "Booking period is not available";
    }
}
