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
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using System.Data.SqlClient;

namespace Magenta.WannaPlay.Components.Infrustructure.Persistence
{
    [TestFixture]
    public class PersistenceRepositoryTest
    {
        public void GenerateSampleDatabase()
        {
            const string databaseFilePath = @"..\..\Generated\Databases\WannaPlay.sdf";

            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = databaseFilePath,
                PersistSecurityInfo = false
            };

            var connectionString = connectionStringBuilder.ToString();

            CreateDatabaseFile(databaseFilePath, connectionString);

            using (var session = new SessionProvider(connectionString).Session)
            {
                CreateDatabaseSchema(session);

                using (var transaction = session.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    new SampleCondo(session);
                    transaction.Commit();
                }
            }
        }

        public void GenerateSqliteSampleDatabase()
        {
            string databaseFilePath = @"..\..\Generated\Databases\WannaPlay.sqlite3";
            
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = databaseFilePath,
            };

            var connectionString = connectionStringBuilder.ToString();

            CreateDatabaseFile(databaseFilePath, connectionString);

            using (var session = new SessionProvider(connectionString).Session)
            {
                CreateDatabaseSchema(session);

                using (var transaction = session.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    new SampleCondo(session);
                    transaction.Commit();
                }
            }
        }

        #region Private

        private void CreateDatabaseFile(string databaseFilePath, string connectionString)
        {
            if (File.Exists(databaseFilePath))
                File.Delete(databaseFilePath);

            using (var sqlCeEngine = new SqlCeEngine(connectionString))
                sqlCeEngine.CreateDatabase();
        }

        private void CreateDatabaseSchema(ISession session)
        {
            using (var transaction = session.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                CreateDatabaseSchema(MsSqlCeConfiguration.Standard, session.Connection);
                transaction.Commit();
            }
        }


        private void CreateDatabaseSchema(IPersistenceConfigurer configurer, IDbConnection connection)
        {
            var schemaExport = new SchemaExport(new WannaPlayPersistenceModel().Configure(configurer));

            schemaExport.Execute(false, true, false, true, connection, null);
        }

        #endregion
    }
}
