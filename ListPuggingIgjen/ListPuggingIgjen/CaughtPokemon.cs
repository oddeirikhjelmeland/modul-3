using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPuggingIgjen
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

        public void PartyInfo()
        {
            Console.WriteLine($"Name: {Name} Level: {Level} ");
        }


    }
}
