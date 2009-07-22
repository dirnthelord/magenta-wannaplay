using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    public class BookingPeriodUI
    {
        [Browsable(false)]
        public DateTimePeriod Period { get; private set; }

        [DisplayName("Period")]
        public virtual string PeriodString { get { return string.Format("{0:h tt} - {1:h tt}", Period.From, Period.To); } }

        public BookingPeriodUI(DateTimePeriod period)
        {
            Period = RequireArg.NotNull(period);
        }
    }
}
