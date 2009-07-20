using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Magenta.Shared.Testing.NHibernate
{
    public class NHibernateTest<TTarget, TPersister, TModel> : UnitTest<TTarget>
        where TPersister : IPersistenceConfigurer, new()
        where TModel : PersistenceModel, new()
    {        
        protected ISessionFactory SessionFactory { get; private set; }

        protected ISession Session { get; private set; }

        protected sealed override void SetupContext()
        {
            var configuration = new TModel().Configure(new TPersister());

            SessionFactory = configuration.BuildSessionFactory();

            SessionFactory.Statistics.IsStatisticsEnabled = true;

            Session = SessionFactory.OpenSession();

            using (var transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                new SchemaExport(configuration).Execute(false, true, false, false, Session.Connection, null);
                transaction.Commit();
            }

            Log("Setting up test context");

            using (var transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                SetupTestContext();
                transaction.Commit();
            }
            
            Session.Clear();
            Log("Running test");
        }

        protected sealed override void TeardownContext()
        {
            TeardownTestContext();
            if (Session.IsOpen)
                Session.Close();
            Session.Dispose();
        }

        protected void Log(string format, params object[] args)
        {
            Console.WriteLine(">>> " + format, args);
        }

        protected virtual void SetupTestContext()
        {
        }

        protected virtual void TeardownTestContext()
        {
        }
    }
}