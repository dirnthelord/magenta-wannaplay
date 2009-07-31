using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Magenta.WannaPlay.Domain;
using NHibernate;
using NHibernate.Linq;

namespace Magenta.WannaPlay.Infrastructure.Persistence
{
    public class PersistenceRepository : IPersistenceRepository
    {
        private readonly ISession _session;

        public PersistenceRepository(ISession session)
        {
            _session = session;
        }

        #region IPersistenceRepository Members

        public void Save<T>(T entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Delete<T>(T entity)
        {
            _session.Delete(entity);
        }

        public IEnumerable<T> Search<T>(params Expression<Func<T, bool>>[] filters)
        {
            return filters
                .Aggregate(_session.Linq<T>().AsQueryable(), (query, filter) => query.Where(filter))
                .ToList();
        }

        #endregion
    }
}