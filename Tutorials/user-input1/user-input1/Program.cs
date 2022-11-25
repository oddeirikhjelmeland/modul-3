using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Enter your age: ");
            String age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are: "+ age);

            Console.ReadLine();



        }
    }
}
