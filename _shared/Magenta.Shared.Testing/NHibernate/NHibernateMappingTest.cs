using FluentNHibernate;
using FluentNHibernate.Cfg.Db;

namespace Magenta.Shared.Testing.NHibernate
{
    public class NHibernateMappingTest<TPersister, TModel> : NHibernateTest<object, TPersister, TModel>
        where TPersister : IPersistenceConfigurer, new()
        where TModel : PersistenceModel, new()
    {
    }
}