using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class BookingSearchRequest
    {
        public ResidenceUnitSearchRequest Unit { get; set; }
        public ResidentSearchRequest Resident { get; set; }

        public BookingSearchRequest()
        {
            Unit = new ResidenceUnitSearchRequest();
            Resident = new ResidentSearchRequest();
        }
    }
}
