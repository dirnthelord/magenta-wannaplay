using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class CancelBookingConfirmationControl : UserControl
    {
        [Inject]
        public IKernel Kernel { get; set; }

        public CancelBookingConfirmationControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CancelBookingConfirmationViewModel ViewModel
        {
            get { return dataContext.DataSource as CancelBookingConfirmationViewModel; }
            set { dataContext.DataSource = value; }
        }
    }
}
