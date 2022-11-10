using System;

namespace MoneyMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("See how much your money would be in Gold Coins!");
            Console.WriteLine("Enter a sum: ");
            string inputAsString = Console.ReadLine();
            double input = Convert.ToDouble(inputAsString);
            Console.WriteLine($"{input} is equal to: ");

            int goldCoin = 10;
            int silverCoin = 5;

            double goldCoins = Math.Floor(input / goldCoin);

            double remainder = input % goldCoin;


            double silverCoins = Math.Floor(remainder / silverCoin);
            remainder = remainder % silverCoins;

            Console.WriteLine($"gold coins = {goldCoins}");
            Console.WriteLine($"silver coins = {silverCoins}");
            Console.WriteLine($"copper coins = {remainder}");
        }
    }
}
