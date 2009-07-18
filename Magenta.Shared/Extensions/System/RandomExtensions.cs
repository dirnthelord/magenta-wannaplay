using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared.Extensions.System
{
    public static class RandomExtensions
    {
        public static T NextItem<T>(this Random random, IList<T> values)
        {
            return values[random.Next(values.Count)];
        }
    }
}
