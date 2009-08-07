using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HibernatingRhinos.NHibernate.Profiler.Appender;
using log4net;
using Magenta.Shared.Ui.WinForms;
using Magenta.WannaPlay.Ioc;
using Magenta.WannaPlay.UI.WinForms.Diagnostics;
using Magenta.WannaPlay.UI.WinForms.Ioc;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Ninject.Core;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared.UI.WinForms;
using Magenta.WannaPlay.UI.WinForms.Services;
using System.Drawing;

namespace Magenta.WannaPlay.UI.WinForms
{
    /// <summary>
    /// Entry point.
    /// Initializes Kernel and shows main application window.
    /// </summary>
    public class WannaPlayApplication
    {
        protected IKernel Kernel { get; private set; }

        public WannaPlayApplication(IKernel kernel)
        {
            Kernel = kernel;
        }

        protected virtual Control GetMainControl()
        {
            var mainControl = Kernel.Get<WannaPlayMainControl>();

            mainControl.ViewModel = Kernel.Get<WannaPlayMainViewModel>();

            return mainControl;
        }

        public void Run()
        {
            //NHibernateProfiler.Initialize();

            var wannaPlayMain = GetMainControl();
            var mainForm = ControlHoster.CreateForm(Resources.WannaPlay, "Wanna Play", wannaPlayMain);
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            //mainForm.Font = new Font(mainForm.Font.FontFamily, 16);

            Kernel.Get<ICommonUIService>().MainForm = mainForm;          

            Application.Run(mainForm);
        }
    }
}
