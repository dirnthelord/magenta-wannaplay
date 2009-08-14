using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class ObjectExtensions
    {
        public static TResult ValueOrDefault<T, TResult>(this T obj, Func<T, TResult> property, TResult defaultValue)
            where T: class
        {
            if (obj == null)
                return defaultValue;

            return property(obj);
        }

        public static TResult ValueOrDefault<T, TResult>(this T obj, Func<T, TResult> property)
            where T: class
        {
            return obj.ValueOrDefault(property, default(TResult));
        }
    }
}
