using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.Ioc;
using System.Threading;
using System.Globalization;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.Test
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-SG");

            var kernel = new StandardKernel(new IModule[] { new MockComponentsConfiguration(), new UIConfiguration() });

            new WannaPlayApplication(kernel).Run();
        }
    }
}
