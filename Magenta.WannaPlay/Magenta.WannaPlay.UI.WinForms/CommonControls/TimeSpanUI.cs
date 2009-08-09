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

        public string ToString(string format)
        {
            return ToString(format, null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                return TimeSpan.ToString();

            var h = TimeSpan.Hours;

            if (h >= 13)
                h -= 12;

            var replacements = new[]
            {
                new { Pattern = "$hour(s)", Replacement =  TimeSpan.TotalHours == 1 ? "hour" : "hours" },
                new { Pattern = "$hh", Replacement = TimeSpan.Hours.ToString("0") },
                new { Pattern = "$h", Replacement =  h.ToString("0") },
                new { Pattern = "$tt", Replacement =  TimeSpan.Hours < 12 ? "AM" : "PM"},
            };

            var result = new StringBuilder(format);

            foreach (var replacement in replacements)
                result.Replace(replacement.Pattern, replacement.Replacement);

            return result.ToString();
        }

        protected override bool EqualsCoreNotNull(TimeSpanUI other)
        {
            return this.TimeSpan == other.TimeSpan;
        }
    }
}
