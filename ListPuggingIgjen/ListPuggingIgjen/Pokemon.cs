using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPuggingIgjen
{
    internal class Pokemon
    {
        public List<CaughtPokemon> PokemonCaught;


        public Pokemon()
        {
            PokemonCaught = new List<CaughtPokemon>();
        }

        public void AddPokemon()
        {
            
            PokemonCaught.Add(new CaughtPokemon("Absol", 99));
            PokemonCaught.Add(new CaughtPokemon("Squrtle", 5));
        }
        public void ShowPokemon()
        {
            foreach(var pokemon in PokemonCaught)
            {
                pokemon.PartyInfo();
            }
        }
    }
}
