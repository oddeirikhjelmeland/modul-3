using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Sykkel
    {

        public Kodelås Kodelås { get; set; }
        public Hjul Hjul { get; set; }
        public string Bremser { get; set;}
        public bool Refleks { get; set; }
        public string Ramme {get; set;}


    public Sykkel(string bremser, bool refleks, string ramme)
        {
            Kodelås = new Kodelås();
            Hjul = new Hjul();
            Bremser = bremser;
            Refleks = refleks;
            Ramme = ramme;
        }

    public Sykkel()
    {
        
    }
    
        //const model = {

        //}
        //       kodelås: { riktig: 4321, antallSiffer: 4},
        //    hjul: { antallEiker: 30, dimensjon: 20 },
        //    bremser: "skivebrems",
        //    refleks: true,
        //    ramme: "aluminium",
    }
}
