using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Exceptions;

namespace Magenta.Shared.DesignByContract
{
    public static class RequireArg
    {
        public static T NotNull<T>(T arg)
        {
            if (arg == null)
                throw ExceptionFactory.ArgumentNull("Requirement was not met");

            return arg;
        }
    }
}
