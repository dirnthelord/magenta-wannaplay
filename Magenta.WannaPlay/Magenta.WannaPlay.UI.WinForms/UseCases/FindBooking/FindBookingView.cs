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
using Magenta.Shared.DesignByContract;
using Magenta.Shared.Aop;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.FindBooking
{
    public partial class FindBookingView : UserControl
    {
        public FindBookingView()
        {
            InitializeComponent();
        }

        public FindBookingController Controller { get; private set; }

        public void SetContext(FindBookingViewModel viewModel, FindBookingController controller)
        {
            dataContext.DataSource = RequireArg.NotNull(viewModel);
            Controller = RequireArg.NotNull(controller);

            findBookingsRequestView.SetContext(viewModel.BookingSearchRequest);
        }

        private void findBookingsButton_Click(object sender, EventArgs e)
        {
            Controller.FindBooking();
        }

        private void findBookingsRequestEditorControl_Enter(object sender, EventArgs e)
        {
            FindForm().AcceptButton = findBookingsButton;
        }
    }
}
