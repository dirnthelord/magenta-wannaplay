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

namespace Magenta.WannaPlay.UI.WinForms
{
    public class WannaPlayApplication
    {
        protected IKernel Kernel { get; private set; }

        public WannaPlayApplication(ComponentsConfiguration componentConfiguration)
        {
            Kernel = new StandardKernel(new IModule[] { componentConfiguration, new UIConfiguration() });
        }

        protected virtual Control GetMainControl()
        {
            return Kernel.Get<WannaPlayMainControl>();
        }

        public void Run()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var wannaPlayMain = GetMainControl();
                var form = ControlHoster.HostInForm(Resources.WannaPlay, "Wanna Play", wannaPlayMain);
                
                // TODO: Dirty coding
                form.Shown += delegate 
                {
                    var currentDutyGuardView = Kernel.Get<CurrentDutyGuardControl>();
                    ControlHoster.HostInForm(null, "Select guard on duty", currentDutyGuardView).ShowDialog(form);
                };

                Application.Run(form);
            }
            catch (Exception e)
            {
                // TODO: Process unhandled exceptions more user-friendly
                MessageBox.Show(e.StackTrace, e.Message);
            }
        }
    }
}
