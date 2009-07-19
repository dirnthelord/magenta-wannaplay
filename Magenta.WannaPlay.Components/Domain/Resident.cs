using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Domain
{
    public class Resident : Entity
    {
        public virtual string Number { get; set; }

        public virtual string Name { get; set; }

        public virtual ResidenceAddress Address { get; set; }
    }
}