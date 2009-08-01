using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HibernatingRhinos.NHibernate.Profiler.Appender;
using log4net;
using Magenta.WannaPlay.Ioc;
using System.Threading;
using System.Globalization;

namespace Magenta.WannaPlay.UI.WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // TODO: Remove
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-SG");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-SG");

            new WannaPlayApplication(new ComponentsConfiguration()).Run();
        }
    }
}
