using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Exceptions;

namespace Magenta.Shared.DesignByContract
{
    public static class RequireArg
    {
        static readonly string StandardErrorMessage = "Requirement was not met";

        public static T NotNull<T>(T arg)
        {
            if (arg == null)
                throw ExceptionFactory.ArgumentNull(StandardErrorMessage);

            return arg;
        }

        public static bool Complies(bool condition)
        {
            if (!condition)
                throw ExceptionFactory.ArgumentOutOfRange(StandardErrorMessage);

            return condition;
        }
    }
}
