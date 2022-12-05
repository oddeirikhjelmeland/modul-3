using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonListe2
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
            PokemonCaught.Add(new CaughtPokemon("Absol", 5));

            var Absol = new CaughtPokemon("Absol" , 5);
            PokemonCaught.Add(Absol);

        }

        public void ShowPokemon()
        {
            
            foreach(var pokemon in PokemonCaught)
            {
                pokemon.PrintInfo();
            }
                
            
        }
    }
}
