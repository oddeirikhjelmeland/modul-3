using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skule
{
    internal class Elever
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Elever(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}  Age: {Age}");
        }

        internal static void PrintInfo(List<Elever> eleverList)
        {
            
        }
    }
}
