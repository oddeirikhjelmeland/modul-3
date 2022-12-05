using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skule
{
    internal class skole
    {
        public string Name { get; set; }

        public List<Elever> eleverList;


        public skole(string name)
        {
            Name = name;
            eleverList = new List<Elever>();

        }

        public skole()
        {
        }

        public void Studenter()
        {
            eleverList.Add(new Elever("Truls", 26));
            eleverList.Add(new Elever("Odd Eirik", 29));
        }

        public void PrintStudents()
        {
            foreach (var Elevers in eleverList)
            {
                Elevers.PrintInfo();
            }
        }
        public void Run()
        {
            Studenter();
            PrintStudents();



        }
    }
}
