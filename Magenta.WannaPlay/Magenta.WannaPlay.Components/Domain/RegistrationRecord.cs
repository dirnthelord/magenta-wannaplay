using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Domain
{
    public abstract class RegistrationRecord : Entity
    {
        public virtual Facility Facility { get; set; }        

        public virtual string Remarks { get; set; }

        public virtual DateTime TimeIn { get; set; }
    }
}
