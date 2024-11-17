using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_SImulator
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int maxHP) : base(name, "Fire", maxHP) { }

        public void Ember(Pokemon opponent)
        {
            Console.WriteLine($"{Name} uses Ember!");
            opponent.TakeDamage(8);
        }

        public void Flamethrower(Pokemon opponent)
        {
            Console.WriteLine($"{Name} uses Flamethrower!");
            opponent.TakeDamage(15);
        }
    }
}
