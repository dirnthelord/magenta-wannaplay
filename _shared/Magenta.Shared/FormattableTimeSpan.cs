using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared
{
    public class FormattableTimeSpan : EquatableBase<FormattableTimeSpan>, IFormattable
    {
        public TimeSpan TimeSpan { get; set; }

        public override string ToString()
        {
            return TimeSpan.ToString();
        }

        public FormattableTimeSpan()
        {
        }

        public FormattableTimeSpan(TimeSpan timeSpan)
        {
            TimeSpan = timeSpan;
        }

        #region IFormattable Members

        public string ToString(string format, IFormatProvider formatProvider)
        {
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

        #endregion

        protected override bool EqualsCoreNotNull(FormattableTimeSpan other)
        {
            return TimeSpan == other.TimeSpan;
        }
    }
}
