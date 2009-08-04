using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    [DefaultBindingProperty("ViewModel")]
    public partial class BookingSearchControl : UserControl
    {
        public BookingSearchControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(true)]
        public BookingSearchViewModel ViewModel
        {
            get { return (BookingSearchViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        private void findBookingsButton_Click(object sender, EventArgs e)
        {
            ViewModel.FindBookings();
        }

        private void bookingSearchResults_SelectionChanged(object sender, EventArgs e)
        {
            ViewModel.SelectedBookings = bookingSearchResults.GetSelectedRowsDataItems<BookingEntryUI>();
        }
    }
}
