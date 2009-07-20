using System.Collections.Generic;

namespace NUnit.Framework
{
    public static class Assertions
    {
        public static void AssertIsEqual<T>(this T actual, T expected)
        {
            Assert.AreEqual(actual, expected);
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
            CollectionAssert.AreEqual(expected, actual);
        }

        public static void AssertSequenceEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected)
        {
            CollectionAssert.AreEqual(expected, actual);
        }

        public static void AssertSetEqual<T>(this IEnumerable<T> actual, params T[] expected)
        {
            CollectionAssert.AreEquivalent(expected, actual);
        }

        public static void AssertSetEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected)
        {
            CollectionAssert.AreEquivalent(expected, actual);
        } 
        #endregion
    }
}
