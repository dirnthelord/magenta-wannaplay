namespace Magenta.WannaPlay.Domain
{
    public class Facility : Entity
    {
        public virtual string Name { get; set; }

        public virtual FacilityType FacilityType { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}