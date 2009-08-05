using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Domain
{
    public class Resident : Entity
    {
        public virtual string PassCardNumber { get; set; }

        public virtual string Name { get; set; }

        public virtual ResidenceUnit Unit { get; set; }

        public Resident()
        {
            Unit = new ResidenceUnit();
        }
    }
}