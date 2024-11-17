namespace Pokemon_Battle_SImulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Instantiating Pokémon
            GrassPokemon bulbasaur = new GrassPokemon("Bulbasaur", 45);
            FirePokemon charmander = new FirePokemon("Charmander", 39);
            WaterPokemon squirtle = new WaterPokemon("Squirtle", 44);

            Console.WriteLine("Pokémon Battle Simulator!");
            bulbasaur.DisplayPokemon();
            charmander.DisplayPokemon();
            squirtle.DisplayPokemon();

            // Example Battle: Bulbasaur vs Charmander
            Console.WriteLine("\nStarting Battle: Bulbasaur vs Charmander!\n");

            while (!bulbasaur.IsDefeated && !charmander.IsDefeated)
            {
                bulbasaur.RazorLeaf(charmander);
                if (charmander.IsDefeated)
                {
                    Console.WriteLine("Charmander has fainted! Bulbasaur wins!");
                    break;
                }

                charmander.Flamethrower(bulbasaur);
                if (bulbasaur.IsDefeated)
                {
                    Console.WriteLine("Bulbasaur has fainted! Charmander wins!");
                    break;
                }
            }

            Console.WriteLine("\nBattle Over!");
        }
    }
}