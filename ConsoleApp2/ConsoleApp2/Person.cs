using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public string Name { get; set; }
        public Kidney Kidney { get; set; }
        public Person(string name, Kidney kidney)
        {
            Name = name;
            Kidney = kidney;
        }
        public string PrintKidneyInfo()
        {
            return Kidney.Print();
        }
    }

}
