namespace Magenta.WannaPlay.Domain
{
    public class ResidenceAddress : Entity
    {
        public virtual string Block { get; set; }

        public virtual string Unit { get; set; }
    }
}