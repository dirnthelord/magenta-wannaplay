using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.Ioc;
using System.Threading;
using System.Globalization;

namespace Magenta.WannaPlay.UI.WinForms.Test
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            ///Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            new WannaPlayApplication(new MockComponentsConfiguration()).Run();
        }
    }
}
