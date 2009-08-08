using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Domain
{
    public class DutyGuard : Entity
    {
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
