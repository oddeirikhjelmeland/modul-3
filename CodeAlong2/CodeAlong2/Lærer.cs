using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong2
{
    internal class Lærer
    {
        public string Name { get; set; }
        public int Modul { get; set; }

        public Lærer(string name, int modul)
        {
            Name = name;
            Modul = modul;
        }
        // Studenter:[{ navn: "Erik", id: 345},{ navn: "Truls", id: 346},],
        //    Lærere:[{ navn: "Joakim", Modul: 3},{ navn: "Linn", Modul: 1},],

    }
}
