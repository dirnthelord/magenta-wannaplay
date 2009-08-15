using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Magenta.Shared;

namespace Magenta.Shared
{
    [TestFixture]
    public class DateTimePeriodTest
    {
        [Test]
        public void Contains()
        {
            var from = new DateTime(2009, 7, 21);
            var middle = from.AddHours(1);
            var to = middle.AddHours(1);

            var period = new DateTimePeriod(from, to);

            period.Contains(PeriodBoundaryType.Inclusive, PeriodBoundaryType.Exclusive, from).AssertIsTrue();
            period.Contains(PeriodBoundaryType.Exclusive, PeriodBoundaryType.Exclusive, from).AssertIsFalse();

            period.Contains(PeriodBoundaryType.Inclusive, PeriodBoundaryType.Inclusive, middle).AssertIsTrue();
            period.Contains(PeriodBoundaryType.Exclusive, PeriodBoundaryType.Exclusive, middle).AssertIsTrue();

            period.Contains(PeriodBoundaryType.Exclusive, PeriodBoundaryType.Inclusive, to).AssertIsTrue();
            period.Contains(PeriodBoundaryType.Exclusive, PeriodBoundaryType.Exclusive, to).AssertIsFalse();
        }
    }
}
