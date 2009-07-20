using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class DateTimeExtentions
    {
        public static DateTime RoundDateDown(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, value.Kind);
        }

        public static DateTime RoundDateUp(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 23, 59, 59, value.Kind);
        }

        public static DateTime RoundToSeconds(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day,
                dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Kind);
        }
    }
}
