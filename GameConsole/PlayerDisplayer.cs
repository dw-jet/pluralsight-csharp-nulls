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
            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);

            // Same as above but using a conditional operator
            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            // Same as above but using null coalescing operator ??
            int days = player.DaysSinceLastLogin ?? -1;


            Console.WriteLine($"{days} days since last login");

            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin);
            //}
            //else
            //{
            //    Console.WriteLine("No value");
            //}

            if (player.DateOfBirth.HasValue)
            {
                Console.WriteLine(player.DateOfBirth);
            }
            else
            {
                Console.WriteLine("No DOB set");
            }

            if (player.isNoob.HasValue)
            {
                if (player.isNoob == true)
                {
                    Console.WriteLine("Player is newbie");
                }
                else
                {
                    Console.WriteLine("Player is experienced");
                }
            }
            else
            {
                Console.WriteLine("Player status is unknown");
            }
        }
    }
}
