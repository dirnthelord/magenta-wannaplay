using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.DesignByContract;

namespace Magenta.Shared
{
    public static class LazyValue
    {
        public static LazyValue<T> Create<T>(Func<T> loader)
        {
            return new LazyValue<T>(loader);
        }
    }

    public class LazyValue<T>
    {
        readonly object _syncObj = new object();

        readonly Func<T> _loader;
        bool _isLoaded;
        T _value;


        public LazyValue(Func<T> loader)
        {
            _loader = RequireArg.NotNull(loader);
        }


        public T Value
        {
            get
            {
                if (_isLoaded)
                    return _value;

                LoadValue();

                return _value;
            }
        }

        void LoadValue()
        {
            lock (_syncObj)
            {
                if (_isLoaded)
                    return;

                _value = _loader();
                _isLoaded = true;
            }
        }
    }
}
