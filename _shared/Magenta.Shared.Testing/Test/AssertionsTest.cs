using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Magenta.Shared.Testing.Test
{
    [TestFixture]
    public class AssertionsTest
    {
        [Test]
        public void AssertSequenceEqual()
        {
            Assert.Throws<AssertionException>(() => new[] { 10, 20 }.AssertSequenceEqual(20, 10));
        }

        [Test]
        public void AssertSetEqual()
        {
            Assert.Throws<AssertionException>(() => new[] { 10, 20 }.AssertSetEqual(30, 10));
        }
    }
}
