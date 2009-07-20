using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Magenta.WannaPlay.Infrastructure.NHibernate
{
    public class OneToManyConvention : IHasManyConvention
    {
        #region IConvention<IOneToManyPart> Members

        public bool Accept(IOneToManyPart target)
        {
            return true;
        }

        public void Apply(IOneToManyPart target)
        {
            target.Cascade.AllDeleteOrphan();
        }

        #endregion
    }
}