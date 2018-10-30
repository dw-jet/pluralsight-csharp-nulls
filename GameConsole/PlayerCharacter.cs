using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly ISpecialDefense _specialDefense;

        public PlayerCharacter(ISpecialDefense specialDefense)
        {
            _specialDefense = specialDefense;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            int damageReduction = 0;

            // Have to handle the null case
            if (_specialDefense != null)
            {
                damageReduction = _specialDefense.CalculateDamageReduction(damage);
            }

            int totalDamageTaken = damage - damageReduction;
            Health -= totalDamageTaken;
            

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }

        // Now uses Nullable<T> shorthand
        public int? DaysSinceLastLogin { get; set; }

        // Now uses Nullable<T> shorthand
        public DateTime? DateOfBirth { get; set; }

        public bool? isNoob { get; set; }
    }
}
