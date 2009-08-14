using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.Ioc;
using System.Threading;
using System.Globalization;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.Shared;
using Magenta.Shared.Ui.WinForms;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Controls.Viewers;
using Magenta.WannaPlay.UI.WinForms.Controls.Editors;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.Test
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-SG");

            var kernel = new StandardKernel(new IModule[] { new MockComponentsConfiguration(), new UIConfiguration() });

            new WannaPlayApplication(kernel).Run();
        }

        [STAThread]
        public static void ControlTest()
        {
            var kernel = new StandardKernel(new IModule[] { new MockComponentsConfiguration(), new UIConfiguration() });

            //var control = new ResidentEditor();
            //var viewModel = kernel.Get<ResidentEditorViewModel>();
            //viewModel.Underlying = new Resident();
            //control.ViewModel = viewModel;

            //Application.Run(ControlHoster.CreateForm(null, null, control));
        }
    }
}
