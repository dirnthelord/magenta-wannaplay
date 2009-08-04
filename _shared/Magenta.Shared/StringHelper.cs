using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared
{
    public class StringHelper
    {
        public static string Join(string separator, IEnumerable<string> values)
        {
            return values.Join(separator);
        }

        public static string Join(string separator, params string[] values)
        {
            return values.Join(separator);
        }
    }
}
