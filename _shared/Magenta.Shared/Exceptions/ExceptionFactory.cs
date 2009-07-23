using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared.Exceptions
{
    public static class ExceptionFactory
    {
        public static ArgumentNullException ArgumentNull(Exception innerException, string format, params object[] args)
        {
            return new ArgumentNullException(string.Format(format, args), innerException);
        }

        public static ArgumentNullException ArgumentNull(string format, params object[] args)
        {
            return ArgumentNull(null, format, args);
        }

        public static ArgumentOutOfRangeException ArgumentOutOfRange(Exception innerException, string format, params object[] args)
        {
            return new ArgumentOutOfRangeException(string.Format(format, args), innerException);
        }

        public static ArgumentOutOfRangeException ArgumentOutOfRange(string format, params object[] args)
        {
            return ArgumentOutOfRange(null, format, args);
        }
    }
}
