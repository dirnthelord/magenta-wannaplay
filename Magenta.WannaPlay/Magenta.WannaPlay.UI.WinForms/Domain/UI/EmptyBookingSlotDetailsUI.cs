using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class EmptyBookingSlotDetailsUI : BookingSlotDetailsUI
    {
        readonly DateTimePeriod _period;


        public EmptyBookingSlotDetailsUI(DateTimePeriod period)
        {
            _period = RequireArg.NotNull(period);
        }


        public override DateTimePeriod Period { get { return _period; } }

        public override bool IsEmpty { get { return true; } }

        public override string BookedByGuard { get { return ""; } }

        public override string ResidentAddress { get { return ""; } }

        public override string ResidentName { get { return ""; } }

        public override string ResidentPassNumber { get { return ""; } }

    }
}
