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
    [ComplexBindingProperties("ItemsSource")]
    public partial class BookingEntryListControl : UserControl
    {
        public BookingEntryListControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object ItemsSource
        {
            get { return dataContext.DataSource ; }
            set { dataContext.DataSource = value; }
        }
    }
}
