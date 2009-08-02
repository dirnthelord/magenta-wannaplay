using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class CancelBookingControl : UserControl
    {
        public CancelBookingControl()
        {
            InitializeComponent();
        }

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public CancelBookingViewModel ViewModel
        //{
        //    get { return (CancelBookingViewModel)dataContext.DataSource; }
        //    set { dataContext.DataSource = value; }
        //}

        private void cancelSelectedBooking_Click(object sender, EventArgs e)
        {

        }
    }
}
