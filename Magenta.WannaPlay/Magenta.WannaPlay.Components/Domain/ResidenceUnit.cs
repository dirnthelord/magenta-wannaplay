namespace Magenta.WannaPlay.Domain
{
    public class ResidenceUnit : Entity
    {
        string _block;
        public virtual string Block
        {
            get { return _block; }
            set { _block = value; OnPropertyChanged("Block"); }
        }

        string _number;
        public virtual string Number
        {
            get { return _number; }
            set { _number = value; OnPropertyChanged("Number"); }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Block, Number);
        }

        public virtual void CopyFrom(ResidenceUnit other)
        {
            // Id should be skipped
            // this.Id = other.Id; 

            this.Block = other.Block;
            this.Number = other.Number;
        }
    }
}