using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    [DefaultBindingProperty("Value")]
    public partial class DateTimePeriodViewer : UserControl
    {
        public DateTimePeriodViewer()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(true)]
        public DateTimePeriod Value
        {
            get { return ViewModel.Underlying; }
            set { ViewModel = new DateTimePeriodViewModel { Underlying = value }; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        DateTimePeriodViewModel ViewModel
        {
            get { return (DateTimePeriodViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

    }
}
