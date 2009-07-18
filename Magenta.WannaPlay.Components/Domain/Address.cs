namespace Magenta.WannaPlay.Domain
{
    public class Address : Entity
    {
        public virtual int Block { get; set; }

        /// <summary>
        /// keep it empty until we need it
        /// </summary>
        public virtual string Street { get; set; }

        public virtual int Unit { get; set; }
    }
}