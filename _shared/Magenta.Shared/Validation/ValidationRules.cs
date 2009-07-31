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
            return _rules.Aggregate(
                new List<ValidationFailure>(), (failures, rule) =>
                                                   {
                                                       if (!rule.Validator(target))
                                                           failures.Add(rule.Failure);
                                                       return failures;
                                                   })
                .ToList();
        }

        public void Add(ValidationRule<T> rule)
        {
            _rules.Add(rule);
        }
    }
}