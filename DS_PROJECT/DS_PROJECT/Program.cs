using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DS_PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            int s_s;

            Console.WriteLine("\n 1.SORTING DATA \n 2.SEARCHING DATA");
            s_s = Convert.ToInt32(Console.ReadLine());
            switch (s_s)
            {
                case 1:
                    if (args is null)
                    {
                        throw new ArgumentNullException(nameof(args));
                    }

                    string textFile = "D:\\GIT\\Sort & Search\\StudentData1.txt";


                    String[] lines = File.ReadAllLines(textFile);
                    Dictionary<String, Int32> Ages = new Dictionary<String, Int32>();

                    foreach (String Age in lines)
                    {
                        String[] split = Age.Split(' ');

                        if (Ages.ContainsKey(split[0]))
                        {
                            foreach (KeyValuePair<String, Int32> kvp in Ages)
                            {
                                if (kvp.Key == split[0])
                                {
                                    Ages[split[0]] += Convert.ToInt32(split[1]);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (split.Length > 1)
                                Ages.Add(split[0], Convert.ToInt32(split[1]));
                        }
                    }

                    var sorted2 = (from entry in Ages orderby entry.Value ascending select entry);
                  
                    Console.WriteLine("\n\nSORT1: Ascending by Age");
                    Console.WriteLine("NAME,AGE");
                    foreach (KeyValuePair<String, Int32> kvp in sorted2)
                        Console.WriteLine("{0},{1}", kvp.Key, kvp.Value);

                    Console.WriteLine("\nPress Any Key to write Sort Data by Age to file...\n");
                    Console.ReadKey();
                   
                    File.WriteAllLines("D:\\GIT\\Sort & Search\\StudentData2.txt", sorted2.Select(x => x.Key + "," + x.Value).ToArray());

                    var sorted4 = (from entry in Ages orderby entry.Key ascending select entry);
                    Console.WriteLine("\n\nSORT2: Ascending by Name");
                    
                    Console.WriteLine("NAME,AGE");
                    foreach (KeyValuePair<String, Int32> kvp in sorted4)
                        Console.WriteLine("{0},{1}", kvp.Key, kvp.Value);

                    Console.WriteLine("\nPress any key to write Sort Data by Name to file...\n");
                    Console.ReadKey();

                    // Write to file
                    File.WriteAllLines("D:\\GIT\\Sort & Search\\StudentData3.txt", sorted4.Select(x => x.Key + "," + x.Value).ToArray());



                    // Exit
                    Console.WriteLine("\nWritten to file!\n");

                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 2:

                    string[] words = File.ReadAllText("D:\\GIT\\Sort & Search\\StudentData1.txt").Split(' ');

                    string wordtobesearch;
                    Console.WriteLine("enter the string to search");
                    wordtobesearch = Console.ReadLine();
                    bool condition = false;
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Contains(wordtobesearch) == true)
                        {

                            condition = true;
                            break;

                        }
                        else
                        {
                            condition = false;
                        }


                    }
                    if (condition == true)
                    {
                        Console.WriteLine("Student Data is Present!!!");
                    }
                    else
                    {
                        Console.WriteLine("Student Data is not present :( ");
                    }
                    Console.ReadLine();
                    break;
                    



            }

        }
    }
}
