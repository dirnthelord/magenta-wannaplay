using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.ComponentModel;

namespace Magenta.Shared.Aop
{
    [TestFixture]
    public class NotifyPropertyChangedAspectTests
    {
        public abstract class Simple : INotifyPropertyChanged
        {
            public abstract string Name { get; set; }
            public abstract event PropertyChangedEventHandler PropertyChanged;
        }

        [Test]
        public void Simple_set_notification_test()
        {
            var obj = ObjectFactory.Create<Simple>();

            var changeHistory = new List<string>();
            obj.PropertyChanged += (s, e) => changeHistory.Add(e.PropertyName);

            obj.Name = "1";
            changeHistory.AssertSequenceEqual("Name");
        }

        [Test]
        public void Simple_no_get_notification_test()
        {
            var obj = ObjectFactory.Create<Simple>();
            obj.Name = "1";

            var changeHistory = new List<string>();
            obj.PropertyChanged += (s, e) => changeHistory.Add(e.PropertyName);

            obj.Name.AssertIsEqual("1");
            changeHistory.AssertIsEmpty();
        }

        public abstract class DependentValueContainer : INotifyPropertyChanged
        {
            public abstract event PropertyChangedEventHandler PropertyChanged;
            public abstract string Left { get; set; }

            string _right;
            public virtual void SpecifyRight(string right)
            {
                _right = right;
            }

            [DependsOn("Left", "SpecifyRight")]
            public virtual string Result
            {
                get { return Left + "-" + _right; }
            }
        }

        [Test]
        public void DependsOnProperty_test()
        {
            var obj = ObjectFactory.Create<DependentValueContainer>();

            var changeHistory = new List<string>();
            obj.PropertyChanged += (s, e) => changeHistory.Add(e.PropertyName);

            obj.Left = "1";
            changeHistory.AssertSequenceEqual("Left", "Result");
        }

        [Test]
        public void DependsOnMethod_test()
        {
            var obj = ObjectFactory.Create<DependentValueContainer>();

            var changeHistory = new List<string>();
            obj.PropertyChanged += (s, e) => changeHistory.Add(e.PropertyName);

            obj.SpecifyRight("2");
            changeHistory.AssertSequenceEqual("Result");
        }

        [Test]
        public void No_notification_for_dependent_getter_test()
        {
            var obj = ObjectFactory.Create<DependentValueContainer>();
            obj.Left = "1";

            var changeHistory = new List<string>();
            obj.PropertyChanged += (s, e) => changeHistory.Add(e.PropertyName);

            obj.Left.AssertIsEqual("1");
            changeHistory.AssertIsEmpty();
        }
    }
}
