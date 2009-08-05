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
    public partial class CancelBookingConfirmationControl : UserControl
    {
        public CancelBookingConfirmationControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CancelBookingConfirmationViewModel ViewModel
        {
            get { return (CancelBookingConfirmationViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }
    }
}
