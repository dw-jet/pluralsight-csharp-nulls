using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        // Strings are reference types (object) so it can null
        public string Name { get; set; }
        // This is a value type (int) so it cannot be null.
        public int DaysSinceLastLogin { get; set; }
        // This is a value type (struct) so it cannot be null.
        public DateTime DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = DateTime.MinValue; // Magic number
            DaysSinceLastLogin = -1; // Magic number
        }
    }
}
