using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string phrase = "Giraffe Academy" + " is cool"; //write how  much you want 
            char  grade = 'A'; //only 1 character
            int age = 30; //a number without decimals
            double gpa = 3.2; // needs a decimal number, can aslo use float and decimal as well
            bool isMale = true; // is a true false thing
            Console.WriteLine(phrase.Length); //prints how many characters there are
            Console.WriteLine(phrase.ToUpper()); // SCREAMS THE CONTENT 
            Console.WriteLine(phrase.Contains("Academy")); // returns true or false if it contains it or not
            Console.WriteLine(phrase[8]); //prints the matching letter to the number
            Console.WriteLine(phrase.Substring(8, 3) ); //prints the character from the number and onword, second is how many character you want to print



            int six = 6;
            Console.WriteLine( 5 % 2 ); //divides then gives the number that remains. Needs a decimal to return a decimal
            Console.WriteLine();
            Console.ReadLine();



        }
    }
}
