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
        /// <summary>
        /// LogManager should be called from main assembly
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        [STAThread]
        static void Main()
        {
            Log.Info("Application has started");

            try
            {
                // TODO: Remove
                //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-SG");
                //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-SG");

                new WannaPlayApplication(new ComponentsConfiguration()).Run();

                Log.Info("Application has stopped");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Initialization error");
                Log.Error("Initialization exception", e);
            }
        }
    }
}
