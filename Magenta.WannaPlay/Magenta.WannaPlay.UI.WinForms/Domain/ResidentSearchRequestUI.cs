using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class ResidentSearchRequest
    {
        public string FacilityCardNumber { get; set; }

        public bool IsSpecified
        {
            get { return !string.IsNullOrEmpty(FacilityCardNumber); }
        }
    }
}
