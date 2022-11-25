namespace listpugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var Pokemon = new Pokemon();

            Pokemon.AddPokemon();

            Console.WriteLine(Pokemon.caughtPokemon.Count);

        }
    }
}