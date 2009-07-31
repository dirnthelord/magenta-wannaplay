using System.Collections.Generic;

namespace Magenta.Shared.Validation
{
    public interface IValidationRules<T>
    {
        IEnumerable<ValidationFailure> Validate(T target);
    }
}