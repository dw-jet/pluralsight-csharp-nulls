using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter {Name = "sarah"},
                new PlayerCharacter(),
                null
            };

            // Array null conditional operator ?[ checks if array element is null
            // Null conditional operator ?. checks if property of object at that element is null
            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            Console.ReadLine();
        }
    }
}
