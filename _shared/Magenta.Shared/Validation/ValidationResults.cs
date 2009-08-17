using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared.Validation
{
    public class ValidationResults
    {
        public readonly IList<ValidationFailure> Failures;

        public ValidationResults(IEnumerable<ValidationFailure> failures)
        {
            Failures = failures.ToList().AsReadOnly();
        }

        public void ThrowIfFailed()
        {
            if (Failures.Count() > 0)
                throw new ValidationException(Failures);
        }
    }
}
