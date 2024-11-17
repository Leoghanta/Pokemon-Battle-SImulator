using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_SImulator
{
    /// <summary>
    /// Grass Pokemon
    /// </summary>
    public class GrassPokemon : Pokemon
    {
        public GrassPokemon(string name, int maxHP) : base(name, "Grass", maxHP) { }

        public void VineWhip(Pokemon opponent)
        {
            Console.WriteLine($"{Name} uses Vine Whip!");
            opponent.TakeDamage(8);
        }

        public void RazorLeaf(Pokemon opponent)
        {
            Console.WriteLine($"{Name} uses Razor Leaf!");
            opponent.TakeDamage(12);
        }
    }
}

