using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    [DefaultBindingProperty("Value")]
    public partial class FindBookingsRequestEditorControl : UserControl
    {
        public FindBookingsRequestEditorControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FindBookingRequestUI Value
        {
            get { return (FindBookingRequestUI)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }
    }
}
