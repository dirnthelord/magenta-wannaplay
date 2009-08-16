using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.DesignByContract;
using System.Globalization;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    public class TimeSpanFormatter
    {
        static readonly DateTime BaseDate = new DateTime(2001, 01, 01);

        public string FormatAsTimeOfDay(TimeSpan timeSpan)
        {
            RequireArg.Complies(timeSpan.TotalHours < 24);

            var dummyDate = BaseDate.Add(timeSpan);

            return dummyDate.ToString("hh.mm tt", CultureInfo.InvariantCulture);
        }

        public string FormatAsLength(TimeSpan timeSpan)
        {
            RequireArg.Complies(timeSpan.TotalHours < 24);

            var hh = timeSpan.Hours;

            return "{0} {1}".FormatString(hh, hh == 1 ? "hour" : "hours");
        }
    }
}
