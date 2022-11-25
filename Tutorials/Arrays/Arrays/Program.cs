using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] luckyNumbers = { 0,1,2,3,4,5,6,7,8,9 };
            string[] friends = new string[3];
            friends[0] = "Erik";
            friends[1] = "David";
            friends[2] = "Magnus";
            for (int y = 0; y < luckyNumbers.Length; y++)
            {
                Console.WriteLine(y);
            }
            luckyNumbers[1] = 10;
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }
            



            Console.ReadLine();

        }
    }
}
