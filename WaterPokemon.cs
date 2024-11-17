using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon_Battle_SImulator
{
    public class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int maxHP) : base(name, "Water", maxHP) { }

        public void WaterGun(Pokemon opponent)
        {
            Console.WriteLine($"{Name} uses Water Gun!");
            opponent.TakeDamage(10);
        }

        public void BubbleBeam(Pokemon opponent)
        {
            Console.WriteLine($"{Name} uses Bubble Beam!");
            opponent.TakeDamage(12);
        }
    }
}
