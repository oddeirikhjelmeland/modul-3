using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouGuessedItWeAreMakingAnotherList
{
    internal class Weapon
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }

        public Weapon(string name, string type, int weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
        }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine("_________________");
        }
    }

   
}
