using System.ComponentModel.DataAnnotations;

namespace aspnetcoreapp.Models
{

    public class ClubEntity: AbstractEntity
    {
        private string name = "";
        private int league;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int League
        {
            get { return league; }
            set { league = value; }
        }

        public override string ToString()
        {
            return base.ToString(); //"[" + ID + ", " + name + ", " + league + "]";
        }
    }
}