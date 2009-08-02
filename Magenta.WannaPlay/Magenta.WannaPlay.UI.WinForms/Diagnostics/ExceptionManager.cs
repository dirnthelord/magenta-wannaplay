using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using log4net;

namespace Magenta.WannaPlay.UI.WinForms.Diagnostics
{
    public class ExceptionManager
    {
        private static readonly ILog Log = LogFactory.Create();

        private readonly ExceptionMessageBox _exceptionMessageBox;

        public ExceptionManager(ExceptionMessageBox exceptionMessageBox)
        {
            _exceptionMessageBox = exceptionMessageBox;

            Application.ThreadException += ThreadExceptionOccured;
            AppDomain.CurrentDomain.UnhandledException += DomainUnhandledException;
        }

        public void HandleException(Exception e)
        {
            Log.Error("Unexpected exception", e);

            _exceptionMessageBox.ShowDialog(e);
        }

        private void ThreadExceptionOccured(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception != null)
                HandleException(e.Exception);
        }

        void DomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;

            if(exception != null)
                HandleException(exception);
        }
    }
}
