using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject
{
    public class Onedayteam : ITeams
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public Onedayteam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.First(player => player.PlayerId == playerId);
        }
        public Player GetPlayerByName(string name)
        {
            return oneDayTeam.First(player => player.PlayerName == name);
        }
        public void Remove(int playerId)
        {
            var index = oneDayTeam.FindIndex(player => player.PlayerId == playerId);
            oneDayTeam.RemoveAt(index);
        }
    }
}
