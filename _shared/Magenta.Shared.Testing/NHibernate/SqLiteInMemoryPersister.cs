using FluentNHibernate.Cfg.Db;

namespace Magenta.Shared.Testing.NHibernate
{
    public class SqLiteInMemoryPersister : SQLiteConfiguration
    {
        public SqLiteInMemoryPersister()
        {
            InMemory().ShowSql();
        }
    }
}