using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    [TestFixture]
    public class DateTimePeriodViewModelTests
    {
        [Test]
        public void ValuesTest()
        {
            var periodFrom = new DateTime(2009, 08, 15, 14, 0, 0);

            var viewModel = new DateTimePeriodViewModel
            {
                Underlying = DateTimePeriod.FromHours(periodFrom, 3)
            };

            viewModel.PeriodDay.AssertIsEqual(periodFrom.ToString("dd MMMM"));
            viewModel.PeriodFrom.AssertIsEqual("02.00 PM");
            viewModel.PeriodFor.AssertIsEqual("3 hours");
        }
    }
}
