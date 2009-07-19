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
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Infrastructure.NHibernate
{
    public class WannaPlayPersistenceModel : AutoPersistenceModel
    {
        public WannaPlayPersistenceModel()
        {
            AddEntityAssembly(Assembly.GetExecutingAssembly())
                .Where(entity => entity.BaseType == typeof(Entity))
                .ConventionDiscovery.Setup(c =>
                {
                    c.Add<WannaPlayForeignKeyConvention>();
                });

            WithSetup(s => s.IsBaseType = type => type == typeof(Entity));
        }
    }
}