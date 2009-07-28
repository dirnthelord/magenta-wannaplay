using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    public class TimeSpanUI : EquatableBase<TimeSpanUI>, IFormattable
    {
        public TimeSpan TimeSpan { get; set; }

        public TimeSpanUI(TimeSpan timeSpan)
        {
            TimeSpan = timeSpan;
        }

        public override string ToString()
        {
            return ToString(null, null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == "nHours")
                return string.Format("{0} {1}", TimeSpan.TotalHours, TimeSpan.TotalHours == 1 ? "hour" : "hours");

            var result = format;

            var h = TimeSpan.Hours;

            if (h >= 13)
                h -= 12;

            var tt = TimeSpan.Hours < 12 ? "AM" : "PM";

            result = result.Replace("$hh", TimeSpan.Hours.ToString("0"));
            result = result.Replace("$h", h.ToString("0"));
            result = result.Replace("$tt", tt);

            return result;
        }

        protected override bool EqualsCoreNotNull(TimeSpanUI other)
        {
            return this.TimeSpan == other.TimeSpan;
        }
    }
}
