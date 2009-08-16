using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Magenta.Shared;

namespace Magenta.Shared
{
    [TestFixture]
    public class ExpressionHelperTest
    {
        [Test]
        public void GetPropertyName()
        {
            var obj = DateTime.Now;

            ExpressionHelper.GetPropertyName(() => obj.DayOfWeek).AssertIsEqual("DayOfWeek");
            ExpressionHelper.GetPropertyName(() => obj.Date.TimeOfDay).AssertIsEqual("Date.TimeOfDay");

            ExpressionHelper.GetPropertyName((DateTime o) => o.DayOfWeek).AssertIsEqual("DayOfWeek");
            ExpressionHelper.GetPropertyName((DateTime o) => o.Date.TimeOfDay).AssertIsEqual("Date.TimeOfDay");
        }
    }
}
