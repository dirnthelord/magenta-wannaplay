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

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class CommonUIService : ICommonUIService
    {
        public IKernel Kernel { get; private set; }

        public CommonUIService(IKernel kernel)
        {
            Kernel = RequireArg.NotNull(kernel);
        }

        public void ChangeDutyGuard()
        {
            var dutyGuardSelector = Kernel.Get<CurrentDutyGuardControl>();
            dutyGuardSelector.ViewModel = Kernel.Get<CurrentDutyGuardViewModel>();

            var buttons = new[]
            {
                new DialogButtonDescription { Text = "OK", IsAcceptButton = true, OnClick = () => dutyGuardSelector.ViewModel.AcceptSelectedDutyGuard() },
                new DialogButtonDescription { Text = "Cancel", IsCancelButton = true }
            };

            ControlHoster.HostInModalDialog(new DialogDescription
            {
                Parent = MainForm,
                Title = "Select guard on duty",
                Content = dutyGuardSelector,
                ButtonDescriptions = buttons,
            });
        }

        public Form MainForm { get; set; }
    }
}
