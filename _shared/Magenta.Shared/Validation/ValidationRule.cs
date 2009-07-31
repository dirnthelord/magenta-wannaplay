using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared.Validation
{
    public class ValidationRule<T>
    {
        /// <summary>
        /// True if validation rule succeded, False otherwise
        /// </summary>
        public Func<T, bool> Validator { get; private set; }

        public ValidationFailure Failure { get; private set; }

        public ValidationRule(Func<T, bool> validator, ValidationFailure failure)
        {
            Validator = validator;
            Failure = failure;
        }
    }
}