using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared
{
    public abstract class EquatableBase<T> : IEquatable<T>
        where T: EquatableBase<T>
    {
        public bool Equals(T other)
        {
            if (other == null)
                return false;

            return EqualsCoreNotNull(other);
        }

        protected abstract bool EqualsCoreNotNull(T other);

        public override bool Equals(object obj)
        {
            if (!(obj is T))
                return false;

            return Equals((T)obj);
        }

        /// <summary>
        /// Returns 0 to make sure hash codes of equal values should always be equal
        /// Override to provide smarter behaviour
        /// </summary>
        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(T left, EquatableBase<T> right)
        {
            return EqualityComparer<T>.Default.Equals(left, (T)right);
        }

        public static bool operator !=(T left, EquatableBase<T> right)
        {
            return !(left == right);
        }
    }
}
