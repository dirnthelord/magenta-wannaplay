using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace System.Reflection
{
    public static class MemberInfoExtensions
    {
        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo member, bool inherit)
        {
            return member.GetCustomAttributes(typeof(T), inherit).Cast<T>();
        }
    }
}
