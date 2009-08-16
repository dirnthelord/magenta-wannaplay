using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    [TestFixture]
    public class TimeSpanFormatterTests
    {
        [Test]
        public void FormatAsTimeOfDay_test()
        {
            Action<TimeSpan, string> Check = (timeSpan, expectedValue) =>
            {
                new TimeSpanFormatter().FormatAsTimeOfDay(timeSpan).AssertIsEqual(expectedValue);
            };

            Check(TimeSpan.FromHours(08), "08.00 AM");
            Check(TimeSpan.FromHours(12), "12.00 PM");
            Check(TimeSpan.FromHours(14), "02.00 PM");
        }

        [Test]
        public void FormatAsLength_test()
        {
            Action<TimeSpan, string> Check = (timeSpan, expectedValue) =>
            {
                new TimeSpanFormatter().FormatAsLength(timeSpan).AssertIsEqual(expectedValue);
            };

            Check(TimeSpan.FromHours(1), "1 hour");
            Check(TimeSpan.FromHours(2), "2 hours");
            Check(TimeSpan.FromHours(20), "20 hours");
        }
    }
}
