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

        public static readonly string DutyGuardIsRequired = "Duty guard is not specified";
        public static readonly string ResidentIsRequired = "Resident is not specified";
        public static readonly string ResidentNameIsRequired = "Resident name is not specified";
        public static readonly string ResidentCardNumberIsRequired = "Resident card number is not specified";
        public static readonly string ResidenceUnitIsRequired = "Residence unit is not specified";

        public static readonly string FacilityIsRequired = "Facility is not specified";
        public static readonly string ResidentIsNotEntitled = "Resident is not entitled to do more booking for the specified date";
    }
}
