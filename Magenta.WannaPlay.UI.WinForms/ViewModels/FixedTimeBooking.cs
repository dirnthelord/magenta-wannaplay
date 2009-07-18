using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class FixedTimeBooking
    {
        [DisplayName("Period")]
        public string Period { get; set; }

        [DisplayName("Booked By")]
        public string BookedBy { get; set; }

        [DisplayName("Block & Unit")]
        public string Address { get; set; }

        [DisplayName("Resident Name")]
        public string ResidentName { get; set; }

        [DisplayName("Facility Card")]
        public string FacilityCard { get; set; }
    }
}
