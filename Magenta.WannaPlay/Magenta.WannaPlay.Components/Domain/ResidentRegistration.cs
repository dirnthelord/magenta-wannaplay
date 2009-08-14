using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Domain
{
    public class ResidentRegistration : RegistrationRecord
    {
        public virtual Resident Resident { get; set; }

        public virtual DateTime TimeOut { get; set; }
    }
}
