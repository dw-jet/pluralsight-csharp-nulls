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
            if (String.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            // Now we are getting the value if set or a default if not
            int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);
            Console.WriteLine($"{days} days since last login");

            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin);
            //}
            //else
            //{
            //    Console.WriteLine("No value");
            //}

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
