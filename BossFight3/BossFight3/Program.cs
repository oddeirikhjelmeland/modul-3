using System;

namespace BossFight3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                GameCharacter cat = new ("cat", 100, 20, 30);
                GameCharacter dog = new("dog", 400, 10, 10);

            while (GameCharacter.isAlive)
            {


                Console.WriteLine($"Cat hp: {cat.Health} Stamina: {cat.Stamina} Attack: {cat.Attack}");
                Console.WriteLine($"Dog hp: {dog.Health} Stamina: {dog.Stamina} Attack: {dog.Attack}");
                cat.Fight(dog);
                dog.Fight(cat);
                Console.WriteLine("---------------------------------------------------------------------");
            }
       


        }
    }
}