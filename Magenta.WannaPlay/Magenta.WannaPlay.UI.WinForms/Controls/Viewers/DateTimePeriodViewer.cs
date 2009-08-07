using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

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
        public DateTimePeriodUI Value
        {
            get { return (DateTimePeriodUI)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }
    }
}
