using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class FacilityBookingControl : UserControl
    {
        public FacilityBookingControl()
        {
            InitializeComponent();
        }

        public FacilityBookingViewModel ViewModel
        {
            get { return (FacilityBookingViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }
    }
}
