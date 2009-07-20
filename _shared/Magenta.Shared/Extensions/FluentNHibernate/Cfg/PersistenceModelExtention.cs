using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;

namespace FluentNHibernate.Cfg
{
    public static class PersistenceModelExtention
    {
        public static Configuration Configure<T>(this T persistenceModel, IPersistenceConfigurer persistenceConfigurer)
            where T : PersistenceModel, new()
        {
            var configuration = Fluently.Configure()
                .Database(persistenceConfigurer)
                .BuildConfiguration();

            new T().Configure(configuration);

            return configuration;
        }
    }
}
