namespace Magenta.WannaPlay.Domain
{
    public class ResidenceUnit : Entity
    {
        public virtual string Block { get; set; }

        public virtual string Number { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Block, Number);
        }
    }
}