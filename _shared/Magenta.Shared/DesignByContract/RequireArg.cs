using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Exceptions;
using System.Diagnostics;

namespace Magenta.Shared.DesignByContract
{
    public static class RequireArg
    {
        static readonly string StandardErrorMessage = "Requirement was not met";

        [DebuggerStepThrough]
        public static T NotNull<T>(T arg)
        {
            return NotNull(arg, null);
        }

        [DebuggerStepThrough]
        public static T NotNull<T>(T arg, string messageFormat, params object[] args)
        {
            if (arg == null)
            {
                var message = StandardErrorMessage;

                if (!messageFormat.IsNullOrEmpty())
                    message += ": " + messageFormat.FormatString(args);

                throw ExceptionFactory.ArgumentNull(message);
            }

            return arg;
        }

        [DebuggerStepThrough]
        public static bool Complies(bool condition)
        {
            if (!condition)
                throw ExceptionFactory.ArgumentOutOfRange(StandardErrorMessage);

            return condition;
        }

        [DebuggerStepThrough]
        public static void HasType<T>(Type type)
        {
            RequireArg.NotNull(type);

            if (!typeof(T).IsAssignableFrom(type))
                throw ExceptionFactory.ArgumentOutOfRange("Type '{0}' is not of type '{1}'", type.Name, typeof(T).Name);
        }
    }
}
