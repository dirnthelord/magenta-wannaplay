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

        public static IEnumerable<T> Tail<T>(this IEnumerable<T> head, IEnumerable<T> tail)
        {
            if (head != null)
                foreach (var value in head)
                    yield return value;

            if (tail != null)
                foreach (var value in tail)
                    yield return value;
        }

        public static IEnumerable<T> Tail<T>(this T head, IEnumerable<T> tail)
        {
            return head.ToEnumerable().Tail(tail);
        }

        public static IEnumerable<T> Tail<T>(this IEnumerable<T> head, params T[] tail)
        {
            return head.Tail(tail.AsEnumerable());
        }

        public static IEnumerable<T> ToEnumerable<T>(this T value)
        {
            yield return value;
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
                action(item);
        }
    }
}
