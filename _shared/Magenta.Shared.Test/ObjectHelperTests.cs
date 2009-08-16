using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Magenta.Shared
{
    [TestFixture]
    public class ObjectHelperTests
    {
        public class MyClass
        {
            public string Name { get; set; }
            public MySubclass Sub { get; set; }
        }

        public class MySubclass
        {
            public double Value { get; set; }
        }

        [Test]
        public void DeepClone_test()
        {
            var obj = new MyClass 
            { 
                Name = "Hello",
                Sub = new MySubclass { Value = 13 } 
            };

            var clone = ObjectHelper.DeepClone(obj);

            clone.Name.AssertIsEqual(obj.Name);
            clone.Sub.AssertIsNotSame(obj.Sub);
            clone.Sub.Value.AssertIsEqual(obj.Sub.Value);
        }
    }
}
