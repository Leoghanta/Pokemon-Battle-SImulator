namespace Pokemon_Battle_SImulator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FirePokemon charmander = new FirePokemon("Charmander");
			WaterPokemon squirtle = new WaterPokemon("Squirtle");
			GrassPokemon bulbasaur = new GrassPokemon("Bulbasaur");

			charmander.IChooseYou();
			squirtle.IChooseYou();

			charmander.Ember(squirtle);
			squirtle.HydroCannon(charmander);

			bulbasaur.IChooseYou();
			bulbasaur.RazorLeaf(charmander);
		}
	}
}