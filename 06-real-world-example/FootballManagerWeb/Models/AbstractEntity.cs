using System.ComponentModel.DataAnnotations;

namespace FootballManager.Models
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