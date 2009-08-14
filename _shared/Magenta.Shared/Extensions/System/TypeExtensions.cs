using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class TypeExtensions
    {
        public static IEnumerable<T> GetCustomAttributes<T>(this Type type, bool inherit)
        {
            return type.GetCustomAttributes(typeof(T), inherit).Cast<T>();
        }
    }
}
