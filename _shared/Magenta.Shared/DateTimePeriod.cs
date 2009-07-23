using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared
{
    public class DateTimePeriod : EquatableBase<DateTimePeriod>
    {
        public virtual DateTime From { get; set; }
        public virtual DateTime To { get; set; }

        public virtual TimeSpan GetTimeSpan()
        {
            return To - From;
        }

        public DateTimePeriod()
        {
        }

        public DateTimePeriod(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }

        protected override bool EqualsCoreNotNull(DateTimePeriod other)
        {
            return From == other.From && To == other.To;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", From, To);
        }


        public bool Contains(PeriodBoundaryType fromType, PeriodBoundaryType toType, DateTime moment)
        {
            var withinFrom =
                (From < moment) ||
                (fromType == PeriodBoundaryType.Inclusive && From == moment);

            var withinTo =
                (To > moment) ||
                (toType == PeriodBoundaryType.Inclusive && To == moment);

            return withinFrom && withinTo;
        }


        public static DateTimePeriod FromTimeSpan(DateTime from, TimeSpan timeSpan)
        {
            return new DateTimePeriod(from, from.Add(timeSpan));
        }

        public static DateTimePeriod FromHours(DateTime from, double hours)
        {
            return new DateTimePeriod(from, from.AddHours(hours));
        }

        public static DateTimePeriod FromDays(DateTime from, double days)
        {
            return new DateTimePeriod(from, from.AddDays(days));
        }

        public static DateTimePeriod Empty
        {
            get { return new DateTimePeriod(); }
        }

        public DateTimePeriod Intersect(DateTimePeriod right)
        {
            if (From > right.From)
                return right.Intersect(this);

            var left = this;

            if (left.To < right.From)
                return DateTimePeriod.Empty;

            return new DateTimePeriod(right.From, DateTimeHelper.Min(right.To, left.To));
        }
    }
}
