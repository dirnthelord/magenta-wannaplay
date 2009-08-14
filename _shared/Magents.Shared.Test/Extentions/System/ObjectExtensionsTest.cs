using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Magenta.Shared.Extentions.System
{
    [TestFixture]
    public class ObjectExtensionsTest
    {
        [Test]
        public void ValueOrDefault_not_null_test()
        {
            var obj = new List<int> { 2 };
            obj.ValueOrDefault(o => o.Count).AssertIsEqual(1);
        }

        [Test]
        public void ValueOrDefault_null_test()
        {
            List<int> obj = null;
            obj.ValueOrDefault(o => o.Count).AssertIsEqual(0);
            obj.ValueOrDefault(o => o.Count, 3).AssertIsEqual(3);
        }
    }
}
