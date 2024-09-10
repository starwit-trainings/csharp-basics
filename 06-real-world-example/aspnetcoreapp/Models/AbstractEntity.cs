using System.ComponentModel.DataAnnotations;

namespace aspnetcoreapp.Models
{
    public abstract class AbstractEntity
    {
        protected int id;

        public int Id
        {
            get {return id;}
            set {id = value;}
        }
    }
}