using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.ComponentModel;

namespace Magenta.Shared.Extentions.System
{
    [TestFixture]
    public class EventHandlerExtensionsTest
    {
        [Test]
        public void Raise_EventHandler_test()
        {
            var wasRaised = false;

            EventHandler handler = (s, e) => wasRaised = true;
            handler.Raise(null, EventArgs.Empty);

            wasRaised.AssertIsTrue();
        }

        [Test]
        public void Raise_GenericEventHandler_test()
        {
            var wasRaised = false;

            EventHandler<CancelEventArgs> handler = (s, e) => wasRaised = true;
            handler.Raise(null, new CancelEventArgs());

            wasRaised.AssertIsTrue();
        }

        [Test]
        public void Raise_PropertyChangedEventHandler_not_null_test()
        {
            var expectedPropertyName = "MyProperty";
            var actualPropertyName = "";

            PropertyChangedEventHandler handler = (s, e) => actualPropertyName = e.PropertyName;
            handler.Raise(null, expectedPropertyName);

            actualPropertyName.AssertIsEqual(expectedPropertyName);
        }

        [Test]
        public void Raise_null_test()
        {
            EventHandler handler = null;
            Assert.DoesNotThrow(() => handler.Raise(null, null));
        }
    }
}
