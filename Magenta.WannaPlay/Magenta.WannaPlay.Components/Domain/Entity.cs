using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.Domain
{
    public abstract class Entity
    {
        public virtual int Id { get; set; }

        static public bool operator ==(Entity x, Entity y)
        {
            return object.Equals(x, y);
            //if ((object)x == null) return (object)y == null;
            //if ((object)y == null) return false;
            //return x.Equals(y);
        }

        static public bool operator !=(Entity x, Entity y)
        {
            return !(x == y);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Entity;
            
            if (other == null)
                return false;

            if (other.Id == 0 || Id == 0)
                return ReferenceEquals(this, obj);

            return other.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}