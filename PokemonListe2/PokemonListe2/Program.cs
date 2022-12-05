namespace PokemonListe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Pokemon = new Pokemon();


            Console.WriteLine(Pokemon.PokemonCaught.Count);
            Pokemon.AddPokemon();
            Pokemon.ShowPokemon();
        }
    }
}