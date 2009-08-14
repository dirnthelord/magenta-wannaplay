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
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    [DefaultBindingProperty("ViewModel")]
    public partial class BookingEntryListControl : UserControl
    {
        public BookingEntryListControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Bindable(true)]
        public BookingEntryListViewModel ViewModel
        {
            get { return dataContext.DataSource as BookingEntryListViewModel; }
            set { dataContext.DataSource = value; }
        }

        private void bookingEntries_SelectionChanged(object sender, EventArgs e)
        {
            ViewModel.SelectedBooking = bookingEntries.SelectedRows.Cast<DataGridViewRow>().Select(r => (BookingEntry)r.DataBoundItem).SingleOrDefault();
        }
    }
}
