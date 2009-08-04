using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class StringExtentions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static string Join(this IEnumerable<string> values, string separator)
        {
            if (values == null)
                return null;

            return string.Join(separator, values.ToArray());
        }
    }
}
