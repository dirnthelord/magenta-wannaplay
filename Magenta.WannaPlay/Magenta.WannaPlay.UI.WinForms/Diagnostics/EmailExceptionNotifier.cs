using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.Diagnostics
{
    public class EmailExceptionNotifier : IExceptionNotifier
    {
        private const string MailSubjectTemplate = "{0} raised exception: {1}";

        [Inject]
        public ApplicationInfo ApplicationInfo { get; set; }

        #region IExceptionNotifier Members

        public bool Notify(Exception exception)
        {
            string command = string.Format("mailto:{0}?subject={1}&body={2}",
                               ApplicationInfo.SupportEMailAddress,
                               BuildMailSubject(exception.Message),
                               ReplaceSpaces(BuildMessageBody(exception)));
            try
            {
                //TODO: implement better ways of creating e-mails
                Process.Start(command.Substring(0, 1800));
            }
            catch (Win32Exception)
            {
                return false;
            }
            return true;
        }

        #endregion

        private string BuildMessageBody(Exception exception)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(exception.Message);
            builder.AppendLine();

            builder.AppendLine("AN EXCEPTION OCCURED:");

            exception.EnumarateExceptions().ForEach(e =>
                                                {
                                                    builder.AppendLine(e.Message);
                                                    builder.AppendLine(e.StackTrace);
                                                    builder.AppendLine();
                                                });

            return builder.ToString();
        }

        private string BuildMailSubject(string mainMessage)
        {
            return string.Format(MailSubjectTemplate, ApplicationInfo.Name, mainMessage);
        }

        private string ReplaceSpaces(string str)
        {
            return str.Replace("\r\n", "%0d%0a").Replace("\n", "%0d%0a").Replace(" ", "%20");
        }
    }
}
