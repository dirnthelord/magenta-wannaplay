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
            return new ArgumentNullException(format.FormatString(args), innerException);
        }

        public static ArgumentNullException ArgumentNull(string format, params object[] args)
        {
            return ArgumentNull(null, format, args);
        }


        public static ArgumentOutOfRangeException ArgumentOutOfRange(string format, params object[] args)
        {
            return ArgumentOutOfRange(null, format, args);
        }

        public static ArgumentOutOfRangeException ArgumentOutOfRange(Exception innerException, string format, params object[] args)
        {
            return new ArgumentOutOfRangeException(format.FormatString(args), innerException);
        }


        public static NotSupportedException NotSupported(string format, params object[] args)
        {
            return NotSupported(null, format, args);
        }

        public static NotSupportedException NotSupported(Exception innerException, string format, params object[] args)
        {
            throw new NotSupportedException(format.FormatString(args), innerException);
        }


        public static InvalidOperationException InvalidOperation(string messageFormat, object[] args)
        {
            return InvalidOperation(null, messageFormat, args);
        }

        public static InvalidOperationException InvalidOperation(Exception innerException, string messageFormat, object[] args)
        {
            return new InvalidOperationException(messageFormat.FormatString(args), innerException);
        }
    }
}
