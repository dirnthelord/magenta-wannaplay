using System;
using System.Collections.Generic;
using System.Data;
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
            using (var transaction = _session.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                _session.SaveOrUpdate(entity); 
                transaction.Commit();
            }
        }

        public void Delete<T>(T entity)
        {
            using (var transaction = _session.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                _session.Delete(entity);
                transaction.Commit();
            }
        }

        public IEnumerable<T> Search<T>(params Expression<Func<T, bool>>[] filters)
        {
            return filters
                .Aggregate(_session.Linq<T>().AsQueryable(), (query, filter) => query.Where(filter))
                .ToList();
        }

        public T GetById<T>(object id)
        {
            return _session.Get<T>(id);
        }

        #endregion
    }
}