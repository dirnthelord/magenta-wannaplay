using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Ninject.Core.Activation;
using Ninject.Core.Creation;

namespace Magenta.WannaPlay.Infrastructure.Persistence
{
    public class SessionProvider : SimpleProvider<ISession>
    {
        public const string DefaultConnectionString = "Data Source=WannaPlay.sdf;Persist Security Info=False;";

        private readonly ISessionFactory _sessionFactory;

        public SessionProvider(string connectionString)
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlCeConfiguration.Standard.ConnectionString(b => b.Is(connectionString)))
                //.ExposeConfiguration(x => x.SetProperty("adonet.batch_size", "1"))
                .BuildConfiguration();

            new WannaPlayPersistenceModel().Configure(configuration);

            _sessionFactory = configuration.BuildSessionFactory();
            Session = _sessionFactory.OpenSession();           
        }

        public SessionProvider()
            : this(DefaultConnectionString)
        {

        }

        public ISession Session { get; private set; }

        protected override ISession CreateInstance(IContext context)
        {
            return Session;
        }
    }
}