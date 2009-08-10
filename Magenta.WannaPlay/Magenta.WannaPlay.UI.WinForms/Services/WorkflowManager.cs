using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Ui.WinForms;
using Magenta.Shared.UI.WinForms;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public interface IWorkflowManager
    {
        void ProcessCancelBooking(BookingEntry bookingToCancel);
    }

    public class WorkflowManager : IWorkflowManager
    {
        private readonly IKernel _kernel;
        private readonly ICommonUIService _commonUIService;

        public WorkflowManager(IKernel kernel, ICommonUIService commonUIService)
        {
            _kernel = kernel;
            _commonUIService = commonUIService;
        }

        #region IWorkflowManager Members

        public void ProcessCancelBooking(BookingEntry bookingToCancel)
        {
            var bookingControl = new CancelBookingConfirmationControl();

            var viewModel = _kernel.Get<CancelBookingConfirmationViewModel>();
            viewModel.Booking = bookingToCancel;

            bookingControl.ViewModel = viewModel;

            ControlHoster.HostInModalDialog(new DialogDescription
            {
                Parent = _commonUIService.MainForm,
                Title = "Cancel booking?",
                Content = bookingControl,
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "Cancel booking", IsAcceptButton = true, OnClick = () => viewModel.DoCancel() },
                    new DialogButtonDescription { Text = "Don't cancel", IsCancelButton = true }     
                },
                Icon = Resources.Cancel.ToBitmap()
            });
        }

        #endregion
    }
}
