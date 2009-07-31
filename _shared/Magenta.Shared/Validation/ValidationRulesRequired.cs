using System;

namespace Magenta.Shared.Validation
{
    public static class ValidationRulesRequired
    {
        public static ValidationRules<T> Required<T>(this ValidationRules<T> rules, Func<T, string> required, string errorId)
        {
            rules.Add(new ValidationRule<T>(x => !required(x).IsNullOrEmpty() , new ValidationFailure(errorId)));
            return rules;
        }

        public static ValidationRules<T> Required<T>(this ValidationRules<T> rules, Func<T, int> required, string errorId)
        {
            rules.Add(new ValidationRule<T>(x => required(x) != 0, new ValidationFailure(errorId)));
            return rules;
        }

        public static ValidationRules<T> Required<T>(this ValidationRules<T> rules, Func<T, double> required, string errorId)
        {
            rules.Add(new ValidationRule<T>(x => required(x) != 0.0, new ValidationFailure(errorId)));
            return rules;
        }

        public static ValidationRules<T> Required<T>(this ValidationRules<T> rules, Func<T, DateTime> required, string errorId)
        {
            rules.Add(new ValidationRule<T>(x => required(x) != DateTime.MinValue, new ValidationFailure(errorId)));
            return rules;
        }

        public static ValidationRules<T> Required<T, K>(this ValidationRules<T> rules, Func<T, K> required, string errorId)
            where K : class
        {
            rules.Add(new ValidationRule<T>(x => required(x) != null, new ValidationFailure(errorId)));
            return rules;
        }

        //public static ValidationRules<T> Assert<T>(this ValidationRules<T> rules, Func<T, bool> assert, string errorId, params object[] parameters)
        //{
        //    rules.Add(new ValidationRule<T>(assert, new ValidationFailure(errorId, parameters)));
        //    return rules;
        //}

        //    //public void Required<K>(Func<T, K> requiredProperty, string errorId)
        //    //{

        //    //}  
    }
}