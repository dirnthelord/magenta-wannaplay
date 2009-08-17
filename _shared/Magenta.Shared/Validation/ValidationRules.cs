using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared.Validation
{
    public class ValidationRules<T> : IValidationRules<T>
    {
        List<ValidationRule<T>> _rules = new List<ValidationRule<T>>();

        public IEnumerable<ValidationFailure> Validate(T target)
        {
            return _rules.Where(r => !r.Validator(target)).Select(r => r.Failure);
        }

        public void Add(ValidationRule<T> rule)
        {
            _rules.Add(rule);
        }
    }
}