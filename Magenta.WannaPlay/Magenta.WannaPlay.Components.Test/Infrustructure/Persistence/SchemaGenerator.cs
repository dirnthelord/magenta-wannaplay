using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Magenta.Shared;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using Environment=System.Environment;

namespace Magenta.WannaPlay.Components.Infrustructure.Persistence
{
    [TestFixture]
    public class SchemaGenerator
    {
        #region Tests

        public void GenerateMsSql2005Script()
        {
            GenerateDatabaseScript(MsSqlConfiguration.MsSql2005, @"..\..\Generated\Schemas\DBSchema_MsSql2005.sql");
        }

        [Test]
        public void GenerateMsSqlCeScript()
        {
            GenerateDatabaseScript(MsSqlCeConfiguration.Standard, @"..\..\Generated\Schemas\DBSchema_MsSqlCE.sql");
        }

        [Test]
        public void GenerateSqLiteScript()
        {
            GenerateDatabaseScript(new SQLiteConfiguration().InMemory().ShowSql(), @"..\..\Generated\Schemas\DBSchema_SqLite.sql");
        }

        [Test]
        public void GenerateMappings()
        {
            var model = new WannaPlayPersistenceModel();

            model.CompileMappings();

            model.WriteMappingsTo(@"..\..\Generated\Mappings\");
        } 


        #endregion

        #region Private

        private void GenerateDatabaseScript(IPersistenceConfigurer configurer, string filePath)
        {           
            var schemaExport = new SchemaExport(new WannaPlayPersistenceModel().Configure(configurer));

            using (var output = new StreamWriter(File.Create(filePath)))
                schemaExport.Execute(true, false, false, true, null, output);
        }

        #endregion
    }
}