using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Magenta.WannaPlay.Domain
{
    public class Resident : Entity
    {
        string _passCardNumber;
        public virtual string PassCardNumber
        {
            get { return _passCardNumber; }
            set { _passCardNumber = value; OnPropertyChanged("PassCardNumber"); }
        }

        string _name;
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        ResidenceUnit _unit;
        public virtual ResidenceUnit Unit
        {
            get { return _unit; }
            set { _unit = value; OnPropertyChanged("Unit"); }
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, PassCardNumber);
        }

        public virtual void CopyFrom(Resident other)
        {
            // Id should be skipped
            //this.Id = other.Id;

            this.Name = other.Name;
            this.PassCardNumber = other.PassCardNumber;
            this.Unit.CopyFrom(other.Unit);
        }
    }
}