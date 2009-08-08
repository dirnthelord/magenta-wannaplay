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
using Magenta.WannaPlay.Domain;

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
            ViewModel.DoSearch();
        }

        private void findBookingsRequestEditorControl_Enter(object sender, EventArgs e)
        {
            FindForm().AcceptButton = findBookingsButton;
        }
    }
}
