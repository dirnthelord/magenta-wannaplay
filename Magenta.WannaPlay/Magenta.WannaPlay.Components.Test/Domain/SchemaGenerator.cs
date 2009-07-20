using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg.Db;
using Magenta.WannaPlay.Infrastructure.NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace Magenta.WannaPlay.Components.Domain
{
    [TestFixture]
    public class SchemaGenerator
    {
        private class MsSqlCeConfiguration : MsSqlConfiguration
        {
            public MsSqlCeConfiguration()
            {
                Dialect<MsSqlCeDialect>();
                ShowSql();
            }
        }

        [Test]
        public void GenerateMsSql2005Schema()
        {
            GenerateSchema(MsSqlConfiguration.MsSql2005, @"..\..\Generated\Schemas\DBSchema_MsSql2005.sql");
        }

        [Test]
        public void GenerateMsSqlCeSchema()
        {
            GenerateSchema(new MsSqlCeConfiguration(), @"..\..\Generated\Schemas\DBSchema_MsSqlCE.sql");
        }

        [Test]
        public void GenerateSqLiteSchema()
        {
            GenerateSchema(new SQLiteConfiguration().InMemory().ShowSql(), @"..\..\Generated\Schemas\DBSchema_SqLite.sql");
        }

        [Test]
        public void GenerateMapping()
        {
            var model = new WannaPlayPersistenceModel();

            model.CompileMappings();
                
            model.WriteMappingsTo(@"..\..\Generated\Mappings\");
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
