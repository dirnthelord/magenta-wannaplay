using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace System
{
    [TestFixture]
    public class DateTimeExtentionsTest
    {
        [Test]
        public void RoundDateUp()
        {
            new DateTime(2008, 12, 19, 10, 12, 13)
                .RoundDateUp().AssertIsEqual(new DateTime(2008, 12, 19, 23, 59, 59));
        }

        [Test]
        public void RoundDateDown()
        {
            new DateTime(2008, 12, 19, 10, 12, 13)
                .RoundDateDown().AssertIsEqual(new DateTime(2008, 12, 19, 0, 0, 0));

        }

        [Test]
        public void RoundToSeconds()
        {
            while(true)
            {
                DateTime now = DateTime.UtcNow;

                if(now.Millisecond > 0)
                {
                    now.RoundToSeconds().Millisecond.AssertIsEqual(0);
                    break;
                }
            }
        }
    }
}
