using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Operation
    {
        public Person[] patients { get; set; }

        public Operation(Person patient1, Person patient2)
        {
            patients = new Person[2];
            patients[0] = patient1;
            patients[1] = patient2;
            
        }

        public void Operate()
        {
            patients[0].Kidney.Part1 = patients[1].Kidney.Part1;
            patients[1].Kidney.Part2 = false;

            Console.WriteLine("Nyrene til Kåre: " + patients[0].Kidney.Part1 + " " + patients[0].Kidney.Part2);
            Console.WriteLine("Nyrene til Bernt: " + patients[1].Kidney.Part1 + " " + patients[1].Kidney.Part2);

            Console.WriteLine("Nyrene til Kåre: " + patients[0].PrintKidneyInfo());
            Console.WriteLine("Nyrene til Bernt: " + patients[1].PrintKidneyInfo());


        }

    }
}
