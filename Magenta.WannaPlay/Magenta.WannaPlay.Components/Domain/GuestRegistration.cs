using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Domain
{
    public class GuestRegistration : RegistrationRecord
    {
        public virtual Resident Resident { get; set; }

        public virtual string GuestName { get; set; }
    }
}
