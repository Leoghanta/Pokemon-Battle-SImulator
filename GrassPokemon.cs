using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_SImulator
{
	internal class GrassPokemon : Pokemon
	{
		public GrassPokemon(String name) : base(name)
		{
			this.Type = "Grass";
		}

		public void RazorLeaf(Pokemon p)
		{
			int damage = 40;
			Console.WriteLine($"{Name} uses RazorLeaf");
			Console.WriteLine($"{Name} sends a blast of razor sharp leaves towards {p.Name}");
			if (p.Type == "Fire")
			{
				damage /= 2;
				Console.WriteLine("The attack was not effective");
			}
			if (p.Type == "Water")
			{
				damage *= 2;
				Console.WriteLine("The attack was supereffective");
			}
			p.DamagePokemon(damage);
		}
	}
}
