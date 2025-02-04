using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSolution
{
    internal class Program
    {
        static Dictionary<string, Team> teams = new Dictionary<string, Team>();
        static Dictionary<string, Player> players = new Dictionary<string, Player>();
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "exit")
            {
                switch (command[0])
                {
                    case "create_team":
                        CreateTeam(command[1]);
                        break;
                    case "create_player":
                        CreatePlayer(command[1], command[2]);
                        break;
                    case "add_player":
                        AddPlaye(command[1], command[2], command[3]);
                        break;
                    case "remove_player":
                        RemovePlayer(command[1], command[2]);
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
        }
        private static void CreateTeam(string teamName)
        {
            teams[teamName] = new Team(teamName);
        }
        private static void CreatePlayer(string playerName, string position)
        {
            players[playerName] = new Player(playerName, position);
        }
        private static void AddPlaye(string teamName, string playerName, string position)
        {
            Player player = players[playerName];
            Team team = teams[teamName];
            team.AddPlayer(player);
        }
        private static void RemovePlayer(string teamName, string playerName)
        {
            Team team = teams[teamName];
            team.RemovePlayer(team, playerName);
        }
    }
}
