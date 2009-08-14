using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.FindBooking
{
    public abstract class BookingSearchRequestViewModel
    {
        public abstract string AddressBlockNumber { get; set; }
        public abstract string AddressUnitNumber { get; set; }
        public abstract string ResidentFacilityCardNumber { get; set; }
    }
}
