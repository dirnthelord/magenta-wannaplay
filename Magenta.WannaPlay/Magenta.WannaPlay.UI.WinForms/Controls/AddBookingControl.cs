using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class AddBookingControl : UserControl
    {
        public AddBookingControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Inject]
        public AddBookingViewModel ViewModel
        {
            get { return (AddBookingViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        private void resident_AutoSuggestRequired(object sender, EventArgs e)
        {
            ViewModel.ResidentAutoFillRequired();
        }
    }
}
