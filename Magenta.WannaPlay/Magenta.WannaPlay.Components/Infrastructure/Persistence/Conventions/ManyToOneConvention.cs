using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Magenta.WannaPlay.Infrastructure.Persistence.Conventions
{
    public class ManyToOneConvention : IReferenceConvention
    {
        #region IConvention<IManyToOnePart> Members

        public bool Accept(IManyToOnePart target)
        {
            return true;
        }

        public void Apply(IManyToOnePart target)
        {
            target.Cascade.All();
        }

        #endregion
    }
}