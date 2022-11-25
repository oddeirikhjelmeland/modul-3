using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Kodelås
    {
        private int Kode = 4321;
        public int AntallSiffer = 4;

        

        public void ÅpneKodeLås()
        {
            Console.WriteLine("Skriv in koden til låsen");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == Kode)
            {
                Console.WriteLine("Koden var rikting");
            }
            else
            {
                Console.WriteLine("Koden var feil");
                
            }
        }
    }


}
