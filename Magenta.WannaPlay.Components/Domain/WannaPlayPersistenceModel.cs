using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FluentNHibernate.AutoMap;
using FluentNHibernate.MappingModel;
using FluentNHibernate.MappingModel.Identity;
using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Magenta.WannaPlay.Domain
{
    //class PrimaryKeyConvention :  IIdConvention  
    //{
    //    public bool Accept(IIdentityPart target)
    //    {
    //        return true;
    //    }

    //    public void Apply(IIdentityPart target)
    //    {
    //        target.GeneratedBy.Sequence(target.Property.ReflectedType + "_seq");
    //    }
    //}

    public class WannaPlayPersistenceModel : AutoPersistenceModel
    {
        public WannaPlayPersistenceModel()
        {
            AddEntityAssembly(Assembly.GetExecutingAssembly())
                .Where(entity => entity.BaseType == typeof(Entity)/* && entity.IsAbstract == false*/);

            //ConventionDiscovery.Add<PrimaryKeyConvention>();

            WithSetup(s => s.IsComponentType = type => type == typeof(PersonName));
            WithSetup(s => s.IsBaseType = type => type == typeof(Entity));
        }
    }
}
