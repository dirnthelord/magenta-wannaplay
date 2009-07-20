using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace Magenta.Shared.Testing
{
    public abstract class UnitTest<T>
    {
        protected T Target { get; private set; }

        [SetUp]
        public void Setup()
        {
            SetupContext();
            Target = CreateTarget();
        }

        [TearDown]
        public void TearDown()
        {
            TeardownContext();
        }

        protected virtual T CreateTarget()
        {
            var ctor = typeof (T).GetConstructor(new Type[0]);

            if(ctor == null)
                throw new InvalidOperationException(
                    string.Format("Type '{0}' does not have parameterless constructor. Please override {1} method",
                                  typeof(T).FullName, new StackTrace().GetFrame(0).GetMethod().Name));

            return (T)ctor.Invoke(null);
        }

        protected virtual void SetupContext()
        {
            
        }

        protected virtual void TeardownContext()
        {

        }
    }
}