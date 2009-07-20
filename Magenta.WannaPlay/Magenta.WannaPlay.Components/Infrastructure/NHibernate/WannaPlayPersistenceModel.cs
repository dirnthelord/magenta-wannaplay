﻿using System;
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
using Magenta.Shared;

namespace Magenta.WannaPlay.Infrastructure.NHibernate
{
    public class WannaPlayPersistenceModel : AutoPersistenceModel
    {
        readonly HashSet<Type> _componentTypes = new HashSet<Type> { typeof(DateTimePeriod) };

        public WannaPlayPersistenceModel()
        {
            AddEntityAssembly(Assembly.GetExecutingAssembly())
                .Where(entity => entity.BaseType == typeof(Entity))
                .ConventionDiscovery.Setup(c =>
                {
                    c.Add<ForeignKeyConvention>();
                    c.Add<ManyToOneConvention>();
                    c.Add<OneToManyConvention>();
                    c.Add<EnumConvention>();
                });

            // TODO: Make it more generic?
            WithSetup(s => s.IsComponentType = type => _componentTypes.Contains(type));

            WithSetup(s => s.IsBaseType = type => type == typeof(Entity));
        }
    }
}