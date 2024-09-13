using System.Diagnostics;
using System.IO;
using entities;
using Microsoft.VisualBasic.FileIO;

namespace FootballManager.entities
{
    internal class DataFunctions
    {
        private List<ClubEntity> clubs;
        private List<LeagueEntity> leagues;

        public List<ClubEntity> Clubs
        { get { return clubs; } }

        public List<LeagueEntity> Leagues
        { get { return leagues; } }

        public DataFunctions()
        {
            clubs = new List<ClubEntity>();
            leagues = new List<LeagueEntity>();
            Trace.WriteLine("Data Functions initialized");
        }

        public void LoadData(string path)
        {
            using (TextFieldParser csvParser = new TextFieldParser(path + "..\\..\\..\\data\\bundesliga_clubs.csv"))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip header
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();
                    int id = Convert.ToInt32(fields[0]);
                    string name = fields[1];
                    int leagueId = Convert.ToInt32(fields[2]);
                    ClubEntity c = new ClubEntity(id, name, leagueId);
                    clubs.Add(c);
                }
            }
            Trace.WriteLine("loaded club data " + clubs.Count);
        }
    }
}
