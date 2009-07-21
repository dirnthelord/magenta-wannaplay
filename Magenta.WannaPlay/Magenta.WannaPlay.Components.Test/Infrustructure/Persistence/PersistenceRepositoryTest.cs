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

namespace Magenta.WannaPlay.Components.Infrustructure.Persistence
{
    [TestFixture]
    public class PersistenceRepositoryTest
    {
        public void GenerateSampleDatabase()
        {
            const string databaseFilePath = @"..\..\Generated\Databases\WannaPlay.sdf";
            var connectionString = string.Format(@"Data Source={0};Persist Security Info=False;", databaseFilePath);

            CreateDatabaseFile(databaseFilePath, connectionString);

            using (var session = new SessionProvider(connectionString).Session)
            {
                CreateDatabaseSchema(session);

                InsertData(session);
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

        private void InsertData(ISession session)
        {
            using (var transaction = session.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                var tennisCourt1 = new Facility { FacilityType = FacilityType.TennisCourt, Name = "Tennis Court 1" };

                session.Save(tennisCourt1);
                session.Save(new Facility { FacilityType = FacilityType.TennisCourt, Name = "Tennis Court 2" });
                session.Save(new Facility { FacilityType = FacilityType.SquashCourt, Name = "Squash Court 1" });
                session.Save(new Facility { FacilityType = FacilityType.SquashCourt, Name = "Squash Court 2" });

                var bradPit = new Resident
                {
                    Name = "Brad Pit",
                    PassCardNumber = "0000",
                    Unit = new ResidenceUnit { Block = "10", Number = "#99-01" }
                };

                var ross = new DutyGuard()
                {
                    Name = "Ross"
                };

                DateTime today = DateTime.UtcNow.Date;

                var bookingEntry = new BookingEntry
                {
                    Facility = tennisCourt1,
                    BookedByGuard = ross,
                    Resident = bradPit,
                    BookedAtDateTime = DateTime.UtcNow.AddDays(-1),
                    Period = new DateTimePeriod(today.AddHours(10), today.AddHours(11))
                };

                session.Save(bookingEntry);

                transaction.Commit();
            }
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
