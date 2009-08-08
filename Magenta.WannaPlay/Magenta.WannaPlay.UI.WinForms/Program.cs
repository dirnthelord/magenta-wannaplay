using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HibernatingRhinos.NHibernate.Profiler.Appender;
using log4net;
using Magenta.WannaPlay.Ioc;
using System.Threading;
using System.Globalization;
using Magenta.WannaPlay.UI.WinForms.Diagnostics;
using Magenta.WannaPlay.UI.WinForms.Ioc;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms
{
    static class Program
    {
        /// <summary>
        /// LogManager should be called from main assembly
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        [STAThread]
        static void Main()
        {
            Log.Info("Application has started");

            StandardKernel kernel = null;

            try
            {
                // TODO: Remove
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-SG");
                //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-SG");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                kernel = new StandardKernel(new IModule[] { new ComponentsConfiguration(), new UIConfiguration() });
                kernel.Get<ExceptionManager>(); // initialize exception manager      

                new WannaPlayApplication(kernel).Run();

                Log.Info("Application has stopped");
            }
            catch (Exception e)
            {
                Log.Error("Initialization exception", e);

                if (kernel != null)
                    kernel.Get<ExceptionManager>().HandleException(e);
                else
                    throw;
            }
        }
    }
}
