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

namespace Magenta.WannaPlay.UI.WinForms
{
    public class WannaPlayApplication
    {
        public void Run()
        {
            try
            {
                IKernel kernel = new StandardKernel(new ComponentsConfiguration(), new UIConfiguration());

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
