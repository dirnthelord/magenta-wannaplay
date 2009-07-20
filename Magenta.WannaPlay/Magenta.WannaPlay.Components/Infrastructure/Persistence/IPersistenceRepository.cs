using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Magenta.WannaPlay.Domain;
using NHibernate;

namespace Magenta.WannaPlay.Infrastructure.Persistence
{
    public interface IPersistenceRepository
    {
        IEnumerable<T> Search<T>(params Expression<Func<T, bool>>[] filters);

        void Save<T>(T entity);

        void Delete<T>(T entity);
    }
}