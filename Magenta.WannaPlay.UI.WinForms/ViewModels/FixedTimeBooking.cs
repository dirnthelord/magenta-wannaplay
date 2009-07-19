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

        public static FixedTimeBooking FromBooking(BookingSlot slot)
        {
            var address = slot.Resident.Address;
            return new FixedTimeBooking
            {
                Address = string.Format("{0} #{1}", address.Block, address.Unit),
                BookedBy = slot.BookedBy.Name,
                FacilityCard = slot.Resident.Number,
                ResidentName = slot.Resident.Name,
                Period = string.Format("{0:hh tt} - {1:hh tt}", slot.FromTime, slot.ToTime),
            };
        }
    }
}
