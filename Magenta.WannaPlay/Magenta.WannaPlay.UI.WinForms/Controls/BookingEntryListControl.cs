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

        public bool AllowMultipleSelection
        {
            get { return bookingEntries.MultiSelect; }
            set { bookingEntries.MultiSelect = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IEnumerable<T> GetSelectedRowsDataItems<T>()
        {
            // TODO: Ensure this code is not duplicated
            return bookingEntries.SelectedRows.Cast<DataGridViewRow>().Select(r => (T)r.DataBoundItem);
        }

        public event EventHandler SelectionChanged
        {
            add { bookingEntries.SelectionChanged += value; }
            remove { bookingEntries.SelectionChanged -= value; }
        }
    }
}
