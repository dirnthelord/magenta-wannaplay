using System;
using System.Linq;
using System.Collections.Generic;

namespace NUnit.Framework
{
    public static class Assertions
    {
        public static void AssertIsEqual<T>(this T actual, T expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void AssertIsSame<T>(this T actual, T expected)
            where T : class
        {
            Assert.AreSame(expected, actual);
        }

        public static void AssertIsNotSame<T>(this T actual, T expected)
            where T : class
        {
            Assert.AreNotSame(expected, actual);
        }

        public static void AssertIsNull(this object left)
        {
            Assert.IsNull(left);
        }

        public static void AssertIsNotNull(this object left)
        {
            Assert.IsNotNull(left);
        }

        public static void AssertIsTrue(this bool value)
        {
            Assert.IsTrue(value);
        }

        public static void AssertIsFalse(this bool value)
        {
            Assert.IsFalse(value);
        }

        #region Collection assertions
        public static void AssertSequenceEqual<T>(this IEnumerable<T> actual, params T[] expected)
        {
            CollectionAssert.AreEqual(expected, actual,
                "Actual sequence is wrong: {0}", actual.Select(x => x.ToString()).Join(", "));
        }

        public static void AssertSequenceEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected)
        {
            CollectionAssert.AreEqual(expected, actual,
                "Actual sequence is wrong: {0}", actual.Select(x => x.ToString()).Join(", "));
        }

        public static void AssertSetEqual<T>(this IEnumerable<T> actual, params T[] expected)
        {
            CollectionAssert.AreEquivalent(expected, actual);
        }

        public static void AssertSetEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected)
        {
            CollectionAssert.AreEquivalent(expected, actual);
        }

        public static void AssertIsEmpty(this System.Collections.IEnumerable collection)
        {
            CollectionAssert.IsEmpty(collection);
        }
        #endregion
    }
}
