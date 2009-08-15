using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Magenta.Shared
{
    [TestFixture]
    public class StringHelperTest
    {
        [Test]
        public void Join()
        {
            StringHelper.Join(",", null).AssertIsEqual(null);
            StringHelper.Join(",", new string[0]).AssertIsEqual("");
            StringHelper.Join(",", new[] { "One" }).AssertIsEqual("One");
            StringHelper.Join(",", new[] { "One", "Two" }).AssertIsEqual("One,Two");
            StringHelper.Join(",", new[] { "One", "Two", "Three" }).AssertIsEqual("One,Two,Three");
        }
    }
}
