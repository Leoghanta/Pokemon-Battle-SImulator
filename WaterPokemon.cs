using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon_Battle_SImulator
{
	internal class WaterPokemon: Pokemon
	{
		public WaterPokemon(String name) : base(name)
		{
			this.Type = "Water";
		}

		public void HydroCannon(Pokemon p)
		{
			int damage = 40;
			Console.WriteLine($"{Name} uses HydroCannon");
			Console.WriteLine($"{Name} blasts a cannon of water towards {p.Name}");
			if (p.Type == "Grass")
			{
				damage /= 2;
				Console.WriteLine("The attack was not effective");
			}
			if (p.Type == "Fire")
			{
				damage *= 2;
				Console.WriteLine("The attack was supereffective");
			}
			p.DamagePokemon(damage);
		}
	}
}
