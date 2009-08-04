using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Magenta.Shared.Extentions.System
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [Test]
        public void Join()
        {
            ((IEnumerable<string>)null).Join(",").AssertIsEqual(null);
            new string[0].Join(",").AssertIsEqual("");
            new[] { "One" }.Join(",").AssertIsEqual("One");
            new[] { "One", "Two" }.Join(",").AssertIsEqual("One,Two");
            new[] { "One", "Two", "Three" }.Join(",").AssertIsEqual("One,Two,Three");
        }
    }
}
