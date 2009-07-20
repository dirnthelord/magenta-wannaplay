using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace System.Collections.Generic
{
    [TestFixture]
    public class EnumerableExtensionsTest
    {
        [Test]
        public void Tail_one_many_test()
        {
            var list = 10.Tail(20.ToEnumerable());
            list.AssertSequenceEqual(10, 20);
        }

        [Test]
        public void Tail_many_one_test()
        {
            var list = 10.ToEnumerable().Tail(20);
            list.AssertSequenceEqual(10, 20);
        }

        [Test]
        public void Tail_many_many_test()
        {
            var list = 10.ToEnumerable().Tail(20.ToEnumerable());
            list.AssertSequenceEqual(10, 20);
        }

        [Test]
        public void ToEnumerable_test()
        {
            var value = 10;
            var list = value.ToEnumerable().ToList();

            list.Count.AssertIsEqual(1);
            list[0].AssertIsEqual(value);
        }
    }
}
