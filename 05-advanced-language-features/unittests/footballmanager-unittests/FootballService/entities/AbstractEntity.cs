namespace entities
{
    public abstract class AbstractEntity
    {
        protected int id;

        public int ID
        {
            get {return id;}
            set {id = value;}
        }
    }
}