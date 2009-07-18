using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared
{
    public class DateTimePeriod
    {
        readonly DateTime _from;
        readonly DateTime _to;

        #region Properties
        public DateTime From
        {
            get { return _from; }
        }

        public DateTime To
        {
            get { return _to; }
        }
        #endregion

        public DateTimePeriod(DateTime from, DateTime to)
        {
            _from = from;
            _to = to;
        }

        public static DateTimePeriod FromHours(DateTime from, double days)
        {
            return new DateTimePeriod(from, from.AddHours(days));
        }

        public static DateTimePeriod FromDays(DateTime from, double days)
        {
            return new DateTimePeriod(from, from.AddDays(days));
        }
    }
}
