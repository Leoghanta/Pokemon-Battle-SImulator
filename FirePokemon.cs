using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_SImulator
{
	internal class FirePokemon : Pokemon
	{
		public FirePokemon(String name) : base(name)
		{
			this.Type = "Fire";
		}

		public void Ember(Pokemon p)
		{
			int damage = 40;
			Console.WriteLine($"{Name} uses Ember");
			Console.WriteLine($"{Name} blasts a torrent of fire towards {p.Name}");
			if (p.Type == "Water")
			{
				damage /= 2;
				Console.WriteLine("The attack was not effective");
			}
			if (p.Type == "Grass")
			{
				damage *= 2;
				Console.WriteLine("The attack was supereffective");
			}
			p.DamagePokemon(damage);

			// Lets burn him
			Random random = new Random();
			if (random.Next(100) < 10)
			{
				p.BurnPokemon();
			}
			
		}

	}
}
