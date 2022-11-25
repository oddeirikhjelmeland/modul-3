using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String secretWord = "banana";
            String guess = "";
            int guessAmount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while (guess != secretWord && !outOfGuesses)
            {
                if (guessAmount < guessLimit )
                {
                    Console.WriteLine("enter guess: ");
                    guess = Console.ReadLine();
                    guessAmount++;
                }
                else
                {
                    outOfGuesses = true;
                }
                
            }
            if (outOfGuesses)
            {
                Console.WriteLine("you lost :(");
            }
            else
            {
                Console.WriteLine("You won woo");
            }
           



            Console.ReadLine();
        }
    }
}
