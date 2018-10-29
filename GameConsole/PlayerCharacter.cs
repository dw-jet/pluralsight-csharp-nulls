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

        // Now uses Nullable<T> shorthand
        public int? DaysSinceLastLogin { get; set; }

        // Now uses Nullable<T> shorthand
        public DateTime? DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;
        }
    }
}
