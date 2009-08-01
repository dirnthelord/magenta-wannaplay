using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading;
using System.Globalization;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    [TestFixture]
    public class TimeSpanUITest
    {
        [Test]
        public void Format_test()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-SG");

            new TimeSpanUI(TimeSpan.FromHours(1)).ToString("$h $hour(s)", null).AssertIsEqual("1 hour");
            new TimeSpanUI(TimeSpan.FromHours(2)).ToString("$h $hour(s)", null).AssertIsEqual("2 hours");

            new TimeSpanUI(TimeSpan.FromHours(7)).ToString("$h $tt", null).AssertIsEqual("7 AM");
            new TimeSpanUI(TimeSpan.FromHours(13)).ToString("$h $tt", null).AssertIsEqual("1 PM");
        }
    }
}
