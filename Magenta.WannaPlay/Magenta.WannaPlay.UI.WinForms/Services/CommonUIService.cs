using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.Controls;
using System.Windows.Forms;
using Ninject.Core;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared.UI.WinForms;
using Magenta.Shared.Ui.WinForms;
using Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.UseCases.CancelBooking;
using Magenta.WannaPlay.UI.WinForms.UseCases.FindBooking;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class CommonUIService : ICommonUIService
    {
        [Inject]
        public IKernel Kernel { get; set; }

        public Form MainForm { get; set; }


        public void ChangeDutyGuard()
        {
            var dutyGuardSelector = Kernel.Get<CurrentDutyGuardEditor>();
            dutyGuardSelector.ViewModel = Kernel.Get<CurrentDutyGuardViewModel>();

            ControlHoster.HostInModalDialog(new DialogDescription
            {
                Parent = MainForm,
                Title = "Select guard on duty",
                Content = dutyGuardSelector,
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "OK", IsAcceptButton = true, OnClick = () => dutyGuardSelector.ViewModel.AcceptSelectedDutyGuard() },
                    new DialogButtonDescription { Text = "Cancel", IsCancelButton = true }
                }
            });
        }

        public void AddBooking(Facility facility, DateTimePeriod period)
        {
            var controller = Kernel.Get<AddBookingController>();
            var viewModel = controller.ViewModel;

            var residentController = Kernel.Get<ResidentController>();

            viewModel.SetContext(facility, period, residentController);

            var view = new AddBookingViewPart();
            view.SetContext(controller.ViewModel, controller);

            var form = ControlHoster.CreateDialog(new DialogDescription
            {
                Parent = MainForm,
                Title = "Add booking",
                Content = view,
                Icon = Resources.AddBooking.ToBitmap(),
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "Add booking", OnClick = () => controller.AddBooking() },
                    new DialogButtonDescription { Text = "Don't add", IsCancelButton = true }     
                },
            });

            form.AddBinding(controller.ViewModel, f => f.Text, vm => vm.BookingTitle);

            form.ShowDialog();
        }

        public void FindBooking()
        {
            var controller = Kernel.Get<FindBookingController>();
            var viewModel = controller.ViewModel;

            var view = new FindBookingView();
            view.SetContext(viewModel, controller);

            ControlHoster.HostInModalDialog(new DialogDescription
            {
                Parent = MainForm,
                Title = "Find booking?",
                Content = view,
                Icon = Resources.Cancel.ToBitmap(),
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "Close", IsCancelButton = true }     
                }
            });
        }

        public void ConfirmCancelBooking(BookingEntry booking)
        {
            var controller = Kernel.Get<CancelBookingConfirmationController>();
            controller.ViewModel.SetContext(booking);

            var view = new CancelBookingConfirmationView();
            view.SetContext(controller.ViewModel, controller);

            ControlHoster.HostInModalDialog(new DialogDescription
            {
                Parent = MainForm,
                Title = "Cancel booking?",
                Content = view,
                Icon = Resources.Cancel.ToBitmap(),
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "Cancel booking", IsAcceptButton = true, OnClick = () => controller.CancelBooking() },
                    new DialogButtonDescription { Text = "Don't cancel", IsCancelButton = true }     
                }
            });
        }
    }
}
