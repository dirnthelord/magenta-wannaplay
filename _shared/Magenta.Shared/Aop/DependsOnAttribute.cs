using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.DesignByContract;

namespace Magenta.Shared.Aop
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class DependsOnAttribute : Attribute
    {
        readonly IEnumerable<string> _memberNames;

        public DependsOnAttribute(params string[] memberNames)
        {
            _memberNames = memberNames;
        }

        public IEnumerable<string> MemberNames
        {
            get { return _memberNames; }
        }
    }
}
