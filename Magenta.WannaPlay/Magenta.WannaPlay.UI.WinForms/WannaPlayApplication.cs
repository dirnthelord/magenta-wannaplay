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
        readonly List<IModule> _componentsConfiguration = new List<IModule>();

        public WannaPlayApplication(params IModule[] componentsConfiguration)
        {
            _componentsConfiguration.AddRange(componentsConfiguration);

            _componentsConfiguration.Add(new UIConfiguration());
        }

        public void Run()
        {
            try
            {
                IKernel kernel = new StandardKernel(_componentsConfiguration.ToArray());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var wannaPlayMain = kernel.Get<WannaPlayMainControl>();
                var form = ControlHoster.HostInForm(Resources.WannaPlay, "Wanna Play", wannaPlayMain);

                Application.Run(form);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, e.Message);
            }
        }
    }
}
