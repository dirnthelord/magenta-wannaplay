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
        }

        public void HandleException(Exception e)
        {
            Log.Error("Unexpected exception", e);

            _exceptionMessageBox.ShowDialog(e);
        }

        private void ThreadExceptionOccured(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception != null)
            {
                HandleException(e.Exception);
            }
        }
    }
}
