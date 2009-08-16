using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.Shared;
using Magenta.Shared.DesignByContract;
using Magenta.Shared.UI.WinForms.Mvvm;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    public class DateTimePeriodViewModel : ViewModelBase
    {
        public DateTimePeriod Underlying { get; set; }

        readonly TimeSpanFormatter TimeSpanFormatter = new TimeSpanFormatter();

        public string PeriodDay { get { return Underlying.From.Date.ToString("dd MMMM"); } }
        public string PeriodFrom { get { return TimeSpanFormatter.FormatAsTimeOfDay(Underlying.From.TimeOfDay); } }
        public string PeriodFor { get { return TimeSpanFormatter.FormatAsLength(Underlying.To - Underlying.From); } }
    }
}
