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
