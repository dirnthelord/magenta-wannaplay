using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Domain
{
    public class Resident : Entity
    {
        public virtual int Number { get; set; }

        public virtual PersonName Name { get; set; }

        public virtual ResidenceAddress Address { get; set; }
    }
}