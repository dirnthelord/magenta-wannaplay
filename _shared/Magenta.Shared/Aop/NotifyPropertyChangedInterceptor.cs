using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Interceptor;
using System.ComponentModel;

namespace Magenta.Shared.Aop
{
    public class NotifyPropertyChangedInterceptor : IInterceptor
    {
        PropertyChangedEventHandler _propertyChangedHandler;
        readonly Dictionary<string, HashSet<string>> _dependantsMap = new Dictionary<string, HashSet<string>>();
        readonly Dictionary<string, object> _abstractPropertyMap = new Dictionary<string, object>();

        public NotifyPropertyChangedInterceptor(Type type)
        {
            BuildDependencyMap(type);
        }

        private void BuildDependencyMap(Type type)
        {
            foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
                foreach (var dependsOnAttr in property.GetCustomAttributes<DependsOnAttribute>(true))
                    foreach (var dependsOn in dependsOnAttr.MemberNames)
                        RegisterDependency(property.Name, dependsOn);
        }

        void RegisterDependency(string propertyName, string dependsOnMember)
        {
            HashSet<string> dependants = null;

            if (!_dependantsMap.TryGetValue(dependsOnMember, out dependants))
                dependants = _dependantsMap[dependsOnMember] = new HashSet<string>();

            dependants.Add(propertyName);
        }

        IEnumerable<string> GetDependingOn(string propertyName)
        {
            HashSet<string> dependants;

            if (_dependantsMap.TryGetValue(propertyName, out dependants))
                return dependants;

            return Enumerable.Empty<string>();
        }

        void OnPropertyChanged(object sender, string propertyName)
        {
            var handler = _propertyChangedHandler;

            if (handler != null)
                handler(sender, new PropertyChangedEventArgs(propertyName));
        }

        public void Intercept(IInvocation invocation)
        {
            string methodName = invocation.Method.Name;

            if (methodName == "add_PropertyChanged")
            {
                _propertyChangedHandler = (PropertyChangedEventHandler)Delegate.Combine(_propertyChangedHandler, (Delegate)invocation.Arguments[0]);
                return;
            }

            if (methodName == "remove_PropertyChanged")
            {
                _propertyChangedHandler = (PropertyChangedEventHandler)Delegate.Remove(_propertyChangedHandler, (Delegate)invocation.Arguments[0]);
                return;
            }

            var getterPrefix = "get_";

            if (invocation.Method.Name.StartsWith(getterPrefix))
            {
                var propertyName = invocation.Method.Name.Substring(getterPrefix.Length);

                if (!invocation.MethodInvocationTarget.IsAbstract)
                {
                    invocation.Proceed();
                    return;
                }

                object value;
                if (_abstractPropertyMap.TryGetValue(propertyName, out value))
                    invocation.ReturnValue = value;

                return;
            }

            var setterPrefix = "set_";

            if (invocation.Method.Name.StartsWith(setterPrefix))
            {
                var propertyName = invocation.Method.Name.Substring(setterPrefix.Length);

                if (!invocation.MethodInvocationTarget.IsAbstract)
                {
                    invocation.Proceed();
                    return;
                }

                _abstractPropertyMap[propertyName] = invocation.Arguments[0];

                OnPropertyChanged(invocation.Proxy, propertyName);
                NotifyDependants(invocation.Proxy, propertyName);

                return;
            }

            NotifyDependants(invocation.Proxy, invocation.Method.Name);
        }

        private void NotifyDependants(object sender, string propertyName)
        {
            GetDependingOn(propertyName)
                .ForEach(dependant => OnPropertyChanged(sender, dependant));
        }
    }
}
