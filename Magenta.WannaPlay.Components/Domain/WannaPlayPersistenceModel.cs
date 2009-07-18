using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FluentNHibernate.AutoMap;

namespace Magenta.WannaPlay.Domain
{
    public class WannaPlayPersistenceModel : AutoPersistenceModel
    {
        public WannaPlayPersistenceModel()
        {
            AddEntityAssembly(Assembly.GetExecutingAssembly())
                .Where(entity => entity.BaseType == typeof(Entity) && entity.IsAbstract == false);

            WithSetup(s => s.IsComponentType = type => type == typeof(PersonName));
        }
    }
}
