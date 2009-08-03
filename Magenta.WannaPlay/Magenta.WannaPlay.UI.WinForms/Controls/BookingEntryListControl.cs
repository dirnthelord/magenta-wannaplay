using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.WannaPlay.UI.WinForms.Controls.GridCells;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    [ComplexBindingProperties("ItemsSource")]
    [DefaultBindingProperty("ItemsSource")]
    public partial class BookingEntryListControl : UserControl
    {
        public BookingEntryListControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<BookingEntryUI> ItemsSource
        {
            get { return dataContext.DataSource as BindingList<BookingEntryUI>; }
            set { dataContext.DataSource = value; }
        }
    }
}
