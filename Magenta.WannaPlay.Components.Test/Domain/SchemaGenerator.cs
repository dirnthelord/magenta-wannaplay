using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg.Db;
using Magenta.WannaPlay.Domain;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Magenta.WannaPlay.Components.Domain
{
    public class SchemaGenerator
    {
        public void GenerateSqLiteSchema()
        {
            GenerateSchema(new SQLiteConfiguration().InMemory().ShowSql(), @"..\..\Generated\DBSchema_SqLite.sql");
        }

        private void GenerateSchema(IPersistenceConfigurer configurer, string filePath)
        {
            var config = new Configuration();
            configurer.ConfigureProperties(config);
            new WannaPlayPersistenceModel().Configure(config);
            var schemaExport = new SchemaExport(config);
            using (var output = new StreamWriter(File.Create(filePath)))
                schemaExport.Execute(true, false, false, true, null, output);
        }
    }
}
