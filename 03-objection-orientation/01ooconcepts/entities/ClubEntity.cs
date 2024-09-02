using ooconcepts;

namespace entities
{

    internal class ClubEntity: AbstractEntity
    {
        private string name = "";
        private int league;

        public ClubEntity(int id, string name, int league)
        {
            this.id = id;
            this.name = name;
            this.league = league;
        }

        public override string ToString()
        {
            return base.ToString(); //"[" + ID + ", " + name + ", " + league + "]";
        }

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
    }
}