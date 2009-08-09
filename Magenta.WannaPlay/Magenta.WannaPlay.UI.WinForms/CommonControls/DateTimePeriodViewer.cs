using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Controls.Viewers
{
    public partial class DateTimePeriodViewer : UserControl
    {
        public DateTimePeriodViewer()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Bindable(true)]
        public DateTimePeriod Value
        {
            get { return ValueUI == null ? null : ValueUI.Underlying; }
            set { ValueUI = new DateTimePeriodUI(value); }
        }

        DateTimePeriodUI ValueUI
        {
            get { return dataContext.DataSource as DateTimePeriodUI; }
            set { dataContext.DataSource = value; }
        }
    }
}
