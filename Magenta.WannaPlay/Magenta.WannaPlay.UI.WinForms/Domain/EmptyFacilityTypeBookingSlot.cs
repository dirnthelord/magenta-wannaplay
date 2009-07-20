using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class EmptyFacilityTypeBookingSlot : FacilityTypeBookingSlot
    {
        readonly DateTimePeriod _period;


        public EmptyFacilityTypeBookingSlot(DateTimePeriod period)
        {
            _period = RequireArg.NotNull(period);
        }


        public override DateTimePeriod Period { get { return _period; } }

        public override bool IsEmpty { get { return true; } }
    }
}
