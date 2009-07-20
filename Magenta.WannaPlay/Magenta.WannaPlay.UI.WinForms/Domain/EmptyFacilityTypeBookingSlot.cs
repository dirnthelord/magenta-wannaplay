using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class EmptyFacilityTypeBookingSlot : FacilityTypeBookingSlot
    {
        readonly DateTimePeriod _period;

        public override DateTimePeriod Period { get { return _period; } }

        public override bool IsEmpty { get { return true; } }

        public EmptyFacilityTypeBookingSlot(DateTimePeriod period)
        {
            _period = RequireArg.NotNull(period);
        }
    }
}
