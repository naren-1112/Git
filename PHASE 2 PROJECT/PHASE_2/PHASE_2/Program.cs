using System;
using System.Collections.Generic;
namespace PHASE_2
{
    class Program
    {
        static void Main(string[] args)
        {
        StartAgain:
            Console.WriteLine("Enter\n 1:To Add Player\n 2:To Remove Player by Id\n 3.Get Player By Id\n 4.Get Player by Name\n 5.Get All Players:\n");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    OneDayTeam odi = new OneDayTeam();
                    if (OneDayTeam.oneDay.Count <= OneDayTeam.oneDay.Capacity)
                    {
                        Console.WriteLine("Enter Player ID");
                        odi.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Player Name:");
                        odi.PlayerName = Console.ReadLine();
                        Console.WriteLine("Enter Player Age:");
                        odi.PlayerAge = Convert.ToInt32(Console.ReadLine());
                        odi.Add(odi);
                        Console.WriteLine("Player Added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("You can't add more than 11 Players.");
                    }
                    break;
                case 2:
                    OneDayTeam odi1 = new OneDayTeam();
                    Console.WriteLine("Enter Player ID to Remove:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    odi1.Remove(id);
                    break;
                case 3:
                    OneDayTeam odi2 = new OneDayTeam();
                    Console.WriteLine("Enter Player ID:");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    Player P = odi2.GetPlayerById(ID);
                    Console.WriteLine("Player ID: " + P.PlayerId);
                    Console.WriteLine("Player Name: " + P.PlayerName);
                    Console.WriteLine("Player Age: " + P.PlayerAge);
                    break;
                case 4:
                    OneDayTeam odi3 = new OneDayTeam();
                    Console.WriteLine("Enter Player Name:");
                    string name = Console.ReadLine();
                    Player P1 = odi3.GetPlayerByName(name);
                    Console.WriteLine("Player ID: " + P1.PlayerId);
                    Console.WriteLine("Player Name: " + P1.PlayerName);
                    Console.WriteLine("Player Age: " +P1.PlayerAge);
                    break;
                case 5:
                    Console.WriteLine("All Players details:");
                    List<Player> all_data = new List<Player>();
                    OneDayTeam odi4 = new OneDayTeam();
                    all_data = odi4.GetAllPlayers();
                    foreach (var data in all_data)
                    {
                        Console.WriteLine("Player ID: " + data.PlayerId);
                        Console.WriteLine("Player Name: " + data.PlayerName);
                        Console.WriteLine("Player Age: " + data.PlayerAge);
                    }
                    break;
                default:
                    Environment.Exit(0);
                    break;

            }
            Console.WriteLine("Do you want to continue (yes/no)?");
            string s = Console.ReadLine();
            if (s == "yes")
            {
                goto StartAgain;
            }
            else if (s == "no")
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }

    }
}
