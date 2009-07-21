using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class BookingSlot
    {
        public DateTimePeriod Period { get; set; }
        public Facility Facility { get; set; }
    }
}
