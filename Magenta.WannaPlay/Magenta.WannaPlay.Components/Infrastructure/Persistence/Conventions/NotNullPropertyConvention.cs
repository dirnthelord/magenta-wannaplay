using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Magenta.WannaPlay.Infrastructure.Persistence.Conventions
{
    public class NotNullPropertyConvention : IPropertyConvention
    {
        #region IConvention<IProperty> Members

        public bool Accept(IProperty target)
        {
            return true;
        }

        public void Apply(IProperty target)
        {
            target.Not.Nullable();
        }

        #endregion
    }
}