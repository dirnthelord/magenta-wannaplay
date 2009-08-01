using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared.Ui.WinForms;
using Magenta.WannaPlay.Ioc;
using Magenta.WannaPlay.UI.WinForms.Ioc;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Ninject.Core;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared.UI.WinForms;
using Magenta.WannaPlay.UI.WinForms.Services;

namespace Magenta.WannaPlay.UI.WinForms
{
    /// <summary>
    /// Entry point.
    /// Initializes Kernel and shows main application window.
    /// </summary>
    public class WannaPlayApplication
    {
        protected IKernel Kernel { get; private set; }

        public WannaPlayApplication(ComponentsConfiguration componentConfiguration)
        {
            Kernel = new StandardKernel(new IModule[] { componentConfiguration, new UIConfiguration() });
        }

        protected virtual Control GetMainControl()
        {
            var mainControl = Kernel.Get<WannaPlayMainControl>();

            mainControl.ViewModel = Kernel.Get<WannaPlayMainViewModel>();

            return mainControl;
        }

        public void Run()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var wannaPlayMain = GetMainControl();
                var mainForm = ControlHoster.HostInForm(Resources.WannaPlay, "Wanna Play", wannaPlayMain);

                Kernel.Get<ICommonUIService>().MainForm = mainForm;

                Application.Run(mainForm);
            }
            catch (Exception)
            {
                throw;
                // TODO: Process unhandled exceptions more user-friendly
                //MessageBox.Show(e.StackTrace, e.Message);
            }
        }
    }
}
