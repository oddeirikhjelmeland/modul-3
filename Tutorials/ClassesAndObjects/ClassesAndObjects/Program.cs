using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Name of the Wind", "Pathrick Rothfuss", 662);
            Book book2 = new Book("The Wise Man's Fear", "Pathrick Rothfuss", 994);

            Console.WriteLine(book1.title);

            Console.ReadLine();
        }
    }
}
