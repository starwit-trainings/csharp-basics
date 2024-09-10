namespace entities
{
    internal class LeagueEntity: AbstractEntity
    {
        private string name = "";
        private DateTime foundingDate;
        private string recordPlayer = "";
        private int gamesRecordPlayer;

        public LeagueEntity(int id, string name, DateTime foundingDate, string recordPlayer, int gamesRecordPlayer)
        {
            this.id = id;
            this.name = name;
            this.foundingDate = foundingDate;
            this.recordPlayer = recordPlayer;
            this.gamesRecordPlayer = gamesRecordPlayer;
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime FoundingDate
        {
            get { return foundingDate; }
            set { foundingDate = value; }            
        }

        public string RecordPlayer
        {
            get { return recordPlayer; }
            set { recordPlayer = value; }
        }   

        public int GamesRecordPlayer
        {
            get { return gamesRecordPlayer; }
            set { gamesRecordPlayer = value; }
        }               
    }
}