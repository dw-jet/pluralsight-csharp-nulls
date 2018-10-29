using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No DOB set");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.isNoob == null)
            {
                Console.WriteLine("Player status is unknown");
            }
            else if (player.isNoob == true)
            {
                Console.WriteLine("Player is newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
