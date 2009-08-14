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
using Magenta.WannaPlay.UI.WinForms.UseCases.CancelBooking;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.CancelBooking
{
    public partial class CancelBookingConfirmationView : UserControl
    {
        public CancelBookingConfirmationView()
        {
            InitializeComponent();
        }

        public CancelBookingConfirmationController Controller { get; private set; }

        public void SetContext(CancelBookingConfirmationViewModel viewModel, CancelBookingConfirmationController controller)
        {
            Controller = RequireArg.NotNull(controller);
            dataContext.DataSource = RequireArg.NotNull(viewModel);
        }
    }
}
