using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Exceptions;
using Magenta.Shared.DesignByContract;

namespace Magenta.Shared.Validation
{
    public class ValidationException : UserFriendlyException
    {
        public IEnumerable<ValidationFailure> Failures { get; private set; }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : base("Validation error(s): " + JoinFailures(failures))
        {
            Failures = RequireArg.NotNull(failures);
        }

        private static string JoinFailures(IEnumerable<ValidationFailure> failures)
        {
            return failures == null
                       ?
                            string.Empty
                       :
                            string.Join(", ", failures.Select(f => f.ErrorId).ToArray());
        }
    }
}