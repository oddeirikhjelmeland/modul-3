namespace ListPuggingIgjen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Pokemon = new Pokemon();

            Pokemon.ShowPokemon();
            Console.WriteLine("___________________________");
            Pokemon.AddPokemon();
            Pokemon.ShowPokemon();
        }
    }
}