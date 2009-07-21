using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Magenta.WannaPlay.Infrastructure.Persistence.Conventions
{
    public class ForeignKeyConvention : IReferenceConvention
    {

        #region IConvention<IManyToManyPart> Members

        public bool Accept(IManyToOnePart target)
        {
            return string.IsNullOrEmpty(target.GetColumnName());
        }

        public void Apply(IManyToOnePart target)
        {
            string columnName = target.Property.Name + "Id";

            target.ColumnName(columnName);
            target.SetAttribute("foreign-key",
                                string.Format("FK_{0}_{1}", target.EntityType.Name, columnName));
        }

        #endregion

    }
}