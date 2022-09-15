using System;
using System.Collections.Generic;

namespace PHASE_2
{
    class OneDayTeam : Player, ITeam
    {
        public static List<Player> oneDay = new List<Player>();
        public OneDayTeam()
        {
            oneDay.Capacity = 11;
        }
        public void Add(Player player)
        {
            oneDay.Add(player);
        }
        public void Remove(int playerId)
        {
            Player P = null;

            foreach (var data in oneDay)
            {
                if (data.PlayerId == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully", data.PlayerId);
                    P = data;
                }
            }
            oneDay.Remove(P);
        }
        public Player GetPlayerById(int playerId)
        {
            Player P = null;

            foreach (var data in oneDay)
            {
                if (data.PlayerId == playerId)
                {
                    P = data;
                    break;
                }
                else
                {
                    Console.WriteLine("Player ID not found.");
                }
            }
            return P;
        }
        public Player GetPlayerByName(string playerName)
        {
            Player P = null;

            foreach (var data in oneDay)
            {
                if (data.PlayerName == playerName)
                {
                    P = data;
                    break;
                }
                else
                {
                    Console.WriteLine("Player Name not found.");
                }
            }
            return P;
        }

        public List<Player> GetAllPlayers()
        {
            return oneDay;
        }

    }
}
