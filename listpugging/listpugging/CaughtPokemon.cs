using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listpugging
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
    }
   
}
