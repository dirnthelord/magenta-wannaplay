using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace System.Collections.Generic
{
    public static class EnumerableExtensions
    {
        public static BindingList<T> ToBindingList<T>(this IEnumerable<T> values)
        {
            return new BindingList<T>(values.ToList());
        }
    }
}
