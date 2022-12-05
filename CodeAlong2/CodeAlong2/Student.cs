using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong2
{
    internal class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }


        public void StudentInfo()
        {
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"ID: {Id}");
        }

        // Studenter:[{ navn: "Erik", id: 345},{ navn: "Truls", id: 346},],
        //    Lærere:[{ navn: "Joakim", Modul: 3},{ navn: "Linn", Modul: 1},],
    }
}
