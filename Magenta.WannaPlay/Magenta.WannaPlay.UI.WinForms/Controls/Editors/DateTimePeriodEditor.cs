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
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    public partial class DateTimePeriodEditor : UserControl
    {
        public DateTimePeriodUI ViewModel
        {
            get { return (DateTimePeriodUI)dataContext.DataSource; }
            set { dataContext.DataSource = value; OnViewModelChanged(); }
        }

        private void OnViewModelChanged()
        {
            timeFrom.DataSource = ViewModel.PeriodFromValues;
            timePeriodLength.DataSource = ViewModel.PeriodForValues;

            FromDay = ViewModel.PeriodDay;
        }

        public DateTimePeriodEditor()
        {
            InitializeComponent();

            timeFrom.FormatString = "h tt";
            timePeriodLength.FormatString = "nHours";
        }

        DateTime FromDay
        {
            get { return dayPicker.Value; }
            set { dayPicker.Value = value; }
        }

        private void dayPicker_ValueChanged(object sender, EventArgs e)
        {
            ViewModel.PeriodDay = FromDay;
        }
    }
}
