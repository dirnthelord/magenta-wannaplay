using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace Magenta.Shared.Aop
{
    public static class ObjectFactory
    {
        static readonly ProxyGenerator Generator = new ProxyGenerator();

        public static T Create<T>()
            where T : class
        {
            var proxy = Generator.CreateClassProxy<T>(new NotifyPropertyChangedInterceptor(typeof(T)));
            return proxy;
        }
    }
}
