using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.Shared;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    public class DateTimePeriodUI : EquatableBase<DateTimePeriodUI>
    {
        public DateTime PeriodDay { get; set; }
        public TimeSpanUI PeriodFor { get; set; }
        public TimeSpanUI PeriodFrom { get; set; }

        public TimeSpan TimeGranularity { get; set; }
        public TimeSpanUI MinimumFromTime { get; set; }
        public TimeSpanUI MaximumToTime { get; set; }

        public BindingList<TimeSpanUI> PeriodFromValues { get; private set; }
        public BindingList<TimeSpanUI> PeriodForValues { get; private set; }

        public DateTimePeriodUI()
        {
            MinimumFromTime = new TimeSpanUI(TimeSpan.FromHours(7));
            MaximumToTime = new TimeSpanUI(TimeSpan.FromHours(22));
            TimeGranularity = TimeSpan.FromHours(1);

            PeriodDay = new DateTime(1999, 12, 24);
            PeriodFrom = new TimeSpanUI(TimeSpan.FromHours(10));
            PeriodFor = new TimeSpanUI(TimeSpan.FromHours(2));

            PeriodFromValues = ScheduleSlots.ToBindingList();
            PeriodForValues = Enumerable.Range(1, 2)
                .Select(i => new TimeSpanUI(new TimeSpan(TimeGranularity.Ticks * i)))
                .ToBindingList();
        }

        IEnumerable<TimeSpanUI> ScheduleSlots
        {
            get
            {
                for (var from = MinimumFromTime.TimeSpan; from < MaximumToTime.TimeSpan; from = from.Add(TimeGranularity))
                    yield return new TimeSpanUI(from);
            }
        }

        public DateTimePeriod Model
        {
            get
            {
                var from = PeriodDay.Add(PeriodFrom.TimeSpan);
                var to = from.Add(PeriodFor.TimeSpan);
                return new DateTimePeriod(from, to);
            }

            set
            {
                RequireArg.Complies(value.From.Date == value.To.Date);

                PeriodDay = value.From.Date;
                PeriodFrom = new TimeSpanUI(value.From.TimeOfDay);
                PeriodFor = new TimeSpanUI(value.To - value.From);
            }
        }

        protected override bool EqualsCoreNotNull(DateTimePeriodUI other)
        {
            return this.Model == other.Model;
        }
    }
}
