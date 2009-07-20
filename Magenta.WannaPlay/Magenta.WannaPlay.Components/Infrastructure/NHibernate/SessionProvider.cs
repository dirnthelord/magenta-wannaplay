using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Ninject.Core.Activation;
using Ninject.Core.Creation;

namespace Magenta.WannaPlay.Infrastructure.NHibernate
{
    public class SessionProvider : SimpleProvider<ISession>
    {
        public const string DefaultFileName = "WannaPlay.db";

        private readonly ISessionFactory _sessionFactory;
        private readonly ISession _session;

        public SessionProvider()
        {
            var configuration = Fluently.Configure()
                .Database(new SQLiteConfiguration().UsingFile(DefaultFileName))
                //.ExposeConfiguration(x => x.SetProperty("adonet.batch_size", "1"))
                .BuildConfiguration();

            new WannaPlayPersistenceModel().Configure(configuration);

            _sessionFactory = configuration.BuildSessionFactory();
            _session = _sessionFactory.OpenSession();
        }

        protected override ISession CreateInstance(IContext context)
        {
            return _session;
        }
    }
}