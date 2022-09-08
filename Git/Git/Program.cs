using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("D:\\GIT\\Git\\welcome.txt");
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
