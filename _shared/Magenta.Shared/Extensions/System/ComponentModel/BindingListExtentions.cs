using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace System.ComponentModel
{
    public static class BindingListExtentions
    {
        public static BindingList<T> ReplaceWith<T>(this BindingList<T> list, IEnumerable<T> values)
        {
            list.Clear();

            foreach (var value in values)
                list.Add(value);

            return list;
        }
    }
}
