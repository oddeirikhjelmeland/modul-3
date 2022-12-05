using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonListe2
{
    internal class CaughtPokemon
    {
        public string Name { get; set; }    
        public int Level { get; set; }

        public CaughtPokemon(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}  Age: {Level}");
        }
    }
}
