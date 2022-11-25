using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); // Only works on whole numbers, not with decimals.
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine()); // only works with commas, crashes on periods I.E 1.6 instead of 1,6
            Console.Write("Enter another number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 + num4);

            Console.ReadLine();
        }
    }
}
