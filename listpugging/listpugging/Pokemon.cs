using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listpugging
{
    internal class Pokemon
    {
        public List<CaughtPokemon> caughtPokemon;
        public List<Item> Items;


        public Pokemon()
        {
            caughtPokemon = new List<CaughtPokemon>();
            Items = new List<Item>();
        }

        public void AddPokemon()
        {
            var Absol = new CaughtPokemon("Absol", 5);
            var Garchomp = new CaughtPokemon("Garchomp",10);

            caughtPokemon.Add(Absol);
            caughtPokemon.Add(Garchomp);

        }
    }

  
}
