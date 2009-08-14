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
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public partial class AddBookingViewPart : UserControl
    {
        public AddBookingViewPart()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AddBookingController Controller { get; private set; }

        public void SetContext(AddBookingViewModel viewModel, AddBookingController controller)
        {
            dataContext.DataSource = RequireArg.NotNull(viewModel);
            Controller = RequireArg.NotNull(controller);

            residentView.SetContext(viewModel.ResidentController.ViewModel, viewModel.ResidentController);
        }
    }
}
