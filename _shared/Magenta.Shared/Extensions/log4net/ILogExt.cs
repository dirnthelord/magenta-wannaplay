using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace log4net
{
    public static class ILogExt
    {
        public static void ErrorFormat(this ILog log, Exception e, string format, params object[] args)
        {
            log.Error(string.Format(format, args), e);
        }
    }
}
