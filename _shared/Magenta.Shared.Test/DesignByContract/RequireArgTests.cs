using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.ComponentModel;

namespace Magenta.Shared.DesignByContract
{
    [TestFixture]
    public class RequireArgTests
    {
        [Test]
        public void HasType_test()
        {
            Assert.DoesNotThrow(() => RequireArg.HasType<object>(typeof(object)));
            Assert.DoesNotThrow(() => RequireArg.HasType<object>(typeof(string)));
            Assert.DoesNotThrow(() => RequireArg.HasType<IComparable>(typeof(string)));

            Assert.Throws<ArgumentNullException>(() => RequireArg.HasType<string>(null));

            Assert.Throws<ArgumentOutOfRangeException>(() => RequireArg.HasType<string>(typeof(object)));
            Assert.Throws<ArgumentOutOfRangeException>(() => RequireArg.HasType<INotifyPropertyChanged>(typeof(object)));
        }
    }
}
