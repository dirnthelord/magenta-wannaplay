using System;

namespace Magenta.Shared.Validation
{
    public static class ValidationRulesAssert
    {
        public static ValidationRules<T> Assert<T>(this ValidationRules<T> rules, Func<T, bool> assert, string errorId)
        {
            rules.Add(new ValidationRule<T>(assert, new ValidationFailure(errorId)));
            return rules;
        }

        public static ValidationRules<T> Assert<T>(this ValidationRules<T> rules, Func<T, bool> assert, string errorId, params object[] parameters)
        {
            rules.Add(new ValidationRule<T>(assert, new ValidationFailure(errorId, parameters)));
            return rules;
        }
    }
}