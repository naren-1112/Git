using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace PhaseLib
    {
        public class Player
        {
            private int _playerid;
            public int PlayerId
            {
                get { return _playerid; }
                set { _playerid = value; }
            }
            private string _playername;

            public string PlayerName
            {
                get { return _playername; }
                set { _playername = value; }
            }
            private int _playerage;

            public int PlayerAge
            {
                get { return _playerage; }
                set { _playerage = value; }
            }
            interface ITeam
            {
                void Add(Player player);
                void Remove(int playerId);
                Player GetPlayerById(int playerId);
                Player GetPlayerByName(string playerName);
                List<Player> GetAllPlayers();
            }
            class OneDayTeam : Player, ITeam
            {
                public static List<Player> oneDayTeam = new List<Player>();
                public OneDayTeam()
                {
                    oneDayTeam.Capacity = 11;
                }
                public void Add(Player player)
                {
                    oneDayTeam.Add(player);
                }
                public void Remove(int playerId)
                {
                    Player p = null;

                    foreach (var i in oneDayTeam)
                    {
                        if (i.PlayerId == playerId)
                        {
                            Console.WriteLine("Player{0} details is removed successfully", i.PlayerId);
                            p = i;
                        }
                    }
                    oneDayTeam.Remove(p);
                }
                public Player GetPlayerById(int playerId)
                {
                    Player p = null;

                    foreach (var i in oneDayTeam)
                    {
                        if (i.PlayerId == playerId)
                        {
                            p = i;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Player ID not found.");
                        }
                    }
                    return p;
                }
                public Player GetPlayerByName(string playerName)
                {
                    Player p = null;

                    foreach (var i in oneDayTeam)
                    {
                        if (i.PlayerName == playerName)
                        {
                            p = i;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Player Name not found.");
                        }
                    }
                    return p;
                }

                public List<Player> GetAllPlayers()
                {
                    return oneDayTeam;
                }
            }

        }
    }


