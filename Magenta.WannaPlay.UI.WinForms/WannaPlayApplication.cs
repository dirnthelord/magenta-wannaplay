using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared.Ui.WinForms;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Magenta.WannaPlay.UI.WinForms.Controls;

namespace Magenta.WannaPlay.UI.WinForms
{
    public class WannaPlayApplication
    {
        public WannaPlayApplication()
        {
        }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TODO: Resolve form from container
            var wannaPlayMain = new WannaPlayMainControl();
            var form = ControlHoster.HostInForm(Resources.WannaPlay, "Wanna Play", wannaPlayMain);

            Application.Run(form);
        }
    }
}
