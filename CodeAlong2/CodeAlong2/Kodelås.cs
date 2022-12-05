using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong2
{
    internal class Kodelås
    {
        private int Kode = 1234;
        public int AntarSiffer = 4;

        public Kodelås()
        {
       
        }


        public void OpenLock()
        {
            Console.WriteLine("Please enter the code to enter");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input == Kode)
            {
                Console.WriteLine("Welcome!");
            }


        }


        //Kodelås: { riktig: 1234, antallSiffer: 4},
    }
}
