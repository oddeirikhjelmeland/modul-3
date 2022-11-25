using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckynumbers = { 1, 2, 3, 4, 5, 6, };

            for(int i = 0; i < luckynumbers.Length; i++)
            {
                Console.WriteLine(luckynumbers[i]);
            }

            Console.ReadLine();


        }
    }
}
