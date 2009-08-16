using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Exceptions;

namespace Magenta.Shared.DesignByContract
{
    public static class Require
    {
        public static void Null<T>(T value, string messageFormat, params object[] args)
            where T : class
        {
            if (value != null)
                throw ExceptionFactory.InvalidOperation(messageFormat, args);
        }

        public static T NotNull<T>(T value, string messageFormat, params object[] args)
            where T : class
        {
            if (value == null)
                throw ExceptionFactory.InvalidOperation(messageFormat, args);

            return value;
        }

    }
}
