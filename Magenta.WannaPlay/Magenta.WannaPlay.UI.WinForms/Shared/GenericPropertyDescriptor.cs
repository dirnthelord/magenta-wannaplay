using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Magenta.WannaPlay.UI.WinForms.Shared
{
    public class GenericPropertyDescriptor<T> : PropertyDescriptor
    {
        private T _value;

        public GenericPropertyDescriptor(string name, Attribute[] attrs)
            : base(name, attrs)
        {
        }

        public GenericPropertyDescriptor(string name, T value, Attribute[] attrs)
            : base(name, attrs)
        {
            _value = value;
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get { return this.GetType(); }
        }

        public override object GetValue(object component)
        {
            return _value;
        }

        public override bool IsReadOnly
        {
            get { return AttributeArray.Any(attr => attr is ReadOnlyAttribute); }
        }

        public override Type PropertyType
        {
            get { return typeof(T); }
        }

        public override void ResetValue(object component)
        {
        }

        public override void SetValue(object component, object value)
        {
            _value = (T)value;
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
