using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared;
using Magenta.Shared.DesignByContract;
using System.Text.RegularExpressions;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class BookingPeriodControl : UserControl
    {
        public BookingPeriodControl()
        {
            InitializeComponent();

            MinimumFromTime = TimeSpan.FromHours(7);
            MaximumToTime = TimeSpan.FromHours(22);
            TimeGranularity = TimeSpan.FromHours(1);
            AllowablePeriods = new BindingList<FormattableTimeSpan>();

            timeFrom.FormatString = "$h $tt";
            timePeriodLength.FormatString = "$hh hours";

            UpdateAllowablePeriods();

            timeFrom.DataSource = ScheduleSlots.ToBindingList();
            timePeriodLength.DataSource = AllowablePeriods;
        }

        IEnumerable<FormattableTimeSpan> ScheduleSlots
        {
            get
            {
                for (var from = MinimumFromTime; from < MaximumToTime; from = from.Add(TimeGranularity))
                    yield return new FormattableTimeSpan(from);
            }
        }

        TimeSpan TimeGranularity { get; set; }
        TimeSpan MinimumFromTime { get; set; }
        TimeSpan MaximumToTime { get; set; }
        public BindingList<FormattableTimeSpan> AllowablePeriods { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTimePeriod Value
        {
            get
            {
                return DateTimePeriod.FromTimeSpan(SelectedDay.Add(FromTime), PeriodLength);
            }
            set
            {
                if (value == null)
                    return;

                RequireArg.Complies(value.From.Date == value.To.Date);

                SelectedDay = value.From.Date;
                FromTime = value.From.TimeOfDay;
                PeriodLength = value.GetTimeSpan();

                UpdateAllowablePeriods();
            }
        }

        DateTime SelectedDay
        {
            get { return dayPicker.Value; }
            set { dayPicker.Value = value; }
        }

        TimeSpan FromTime
        {
            get { return ((FormattableTimeSpan)timeFrom.SelectedItem).TimeSpan; }
            set { timeFrom.SelectedItem = new FormattableTimeSpan(value); }
        }

        TimeSpan PeriodLength
        {
            get { return ((FormattableTimeSpan)timePeriodLength.SelectedItem).TimeSpan; }
            set { timePeriodLength.SelectedItem = new FormattableTimeSpan(value); }
        }

        private void timeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateAllowablePeriods();
        }

        private void UpdateAllowablePeriods()
        {
            AllowablePeriods.ReplaceWith(new[] 
            { 
                new FormattableTimeSpan(TimeSpan.FromHours(1)),
                new FormattableTimeSpan(TimeSpan.FromHours(2)),
            });
        }
    }
}
