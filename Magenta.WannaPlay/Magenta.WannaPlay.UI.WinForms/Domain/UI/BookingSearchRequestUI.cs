using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    public class BookingSearchRequestUI
    {
        public ResidenceUnitSearchRequestUI Unit { get; set; }
        public ResidentSearchRequestUI Resident { get; set; }

        public BookingSearchRequestUI()
        {
            Unit = new ResidenceUnitSearchRequestUI();
            Resident = new ResidentSearchRequestUI();
        }
    }
}
