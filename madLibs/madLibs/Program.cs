using System;

namespace madLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is fun");
            Console.WriteLine("Author: Me!");


 
            Console.WriteLine("The game is a foot");


            string title = "TITLE: A day in life";

            Console.WriteLine(title);
      
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a Color:");
            string adj1 = Console.ReadLine();
            Console.WriteLine("Enter a feeling:");
            string adj2 = Console.ReadLine();
            Console.WriteLine("Enter a texture:");
            string adj3 = Console.ReadLine();

            Console.WriteLine("Enter a verb:");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter a noun:");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Enter a place:");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter an animal:");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter a food:");
            string food = Console.ReadLine();
            Console.WriteLine("Enter a fruit:");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter a superhero:");
            string superhero = Console.ReadLine();
            Console.WriteLine("Enter a country:");
            string country = Console.ReadLine();
            Console.WriteLine("Enter a dessert:");
            string dessert = Console.ReadLine();
            Console.WriteLine("Enter a year:");
            string year = Console.ReadLine();

          

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' O" +
                $"utside, a bunch of " +$"{animal}s were protesting to keep {food} in stores. " +
                $"They began to {verb} to the rhythm of the {noun1}, " +
                $"which made all the {fruit}s very {adj3}. Concerned, {name} texted {country}, " +
                $"who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. " +
                $"{name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


          
            Console.WriteLine(story);
        }
    }
    }

