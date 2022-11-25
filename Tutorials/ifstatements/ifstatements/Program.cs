using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifstatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");

            } else if (isMale && !isTall) {
                Console.WriteLine("You are a short little man aren't you?");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not a male but you are tall");
            } else
            {
                Console.WriteLine("You are not male, and not tall");
            }

            Console.ReadLine();
        }
    }
}
