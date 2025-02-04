using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSolution
{
    public class Team
    {
		private string teamName;

		public string TeamName
		{
			get { return teamName; }
			set 
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name shouldn't be null");
                }
                teamName = value; 
            }
		}
		private List<IPlayer> listOfPlayers;

		public List<IPlayer> ListOfPlayers
		{
			get { return listOfPlayers; }
			set 
			{
                if (value.Count==0)
                {
                    throw new ArgumentException("List shouldn't be empty");
                }
                listOfPlayers = value; 
			}
		}

        public Team(string teamName)
        {
            TeamName = teamName;
            ListOfPlayers = new List<IPlayer>();
        }
        public void CreateTeam(string teamName)
        {
            Team team = new Team(teamName);
            Console.WriteLine("A team was created");
        }
        public void CreatePlayer(string name, string position)
        {
            Player player = new Player(name, position);
            Console.WriteLine("A player was craeted");
        }
        public void AddPlayer(IPlayer player)
        {
            ListOfPlayers.Add(player);
            Console.WriteLine($"A player {player.Name} was added");
        }
        public void RemovePlayer(Team teamName, string playerName)
        {
            if (playerName != null)
            {
                var player = listOfPlayers.FirstOrDefault(x => x.Name == playerName);
                ListOfPlayers.Remove(player);
                Console.WriteLine($"Removed {playerName} from {teamName.TeamName}");
            }
            else
            {
                Console.WriteLine("there is no player in that team");
            }
        }
    }
}
