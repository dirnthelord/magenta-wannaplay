using System;
using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Magenta.WannaPlay.Infrastructure.Persistence.Conventions
{
    public class EnumConvention : IUserTypeConvention
    {
        public bool Accept(IProperty target)
        {
            return target.PropertyType.IsEnum;
        }

        public void Apply(IProperty target)
        {
            target.CustomTypeIs(target.PropertyType);
        }

        public bool Accept(Type type)
        {
            return type.IsEnum;
        }
    }
}