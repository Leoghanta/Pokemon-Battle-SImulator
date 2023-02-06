using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_SImulator
{
	/// <summary>
	/// Pokemon Class - 
	/// The base class for all pokemon.
	/// </summary>
	internal class Pokemon
	{
		public String Name = "";
		public String Type = "";
		int MaxHitpoints = 80;
		int Hp = 80; 
		Boolean InBall = true;
		Boolean Burned = false;

		/// <summary>
		/// Constructor for Pokemon - update the name.
		/// </summary>
		/// <param name="name"></param>
		public Pokemon(string name)
		{
			this.Name = name;
		}

		public void IChooseYou()
		{
			if (InBall)
			{
				Console.WriteLine($"{Name} bursts out of the pokeball!");
				InBall = false;
			}
		}

		public void ComeBack()
		{
			if (!InBall)
			{
				Console.WriteLine($"{Name} has returned to you!");
				InBall = true;
			}
		}

		public void QuickAttack(Pokemon p)
		{
			if (InBall)
			{
				Console.WriteLine($"{Name} rattles around in the pokeball, but does not attack!");
				return;
			}

			Console.WriteLine($"{Name} uses quick attack against {p.Name}");
			p.DamagePokemon(20);
		}

		public void DamagePokemon(int damage)
		{
			Console.WriteLine($"{Name} is hurt with the attack");
			Hp = Hp - damage;
			if (Hp <= 0) {
				Console.WriteLine($"{Name} has fainted!");
				Console.WriteLine($"{Name} has returned to the pokeball");
				InBall = true;
			} else
			{
				ShowStats();
			}
		}

		public void BurnPokemon()
		{
			if (Burned)
			{
				Console.WriteLine($"The attack Burned {Name} 🔥🔥");
				Burned = true;
			}
		}

		public void ShowStats()
		{
			Console.WriteLine($"{Name} has {Hp}/{MaxHitpoints}");
		}

	}
}
