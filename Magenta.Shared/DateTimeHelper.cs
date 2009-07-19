using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared
{
    public static class DateTimeHelper
    {
        public static DateTime Min(DateTime left, DateTime right)
        {
            return left.CompareTo(right) < 0 ? left : right;
        }
    }
}
