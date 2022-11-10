using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bossfight
{
    internal class GameCharacter
    {
        public static bool isAlive = true;
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int OrigonalStamina;

        public GameCharacter(int health, int strength, int stamina, string name)
        {

            Health = health;
            Strength = strength;
            Stamina = stamina;
            Name = name;
            OrigonalStamina = stamina;
        }

        public void Fight(GameCharacter opponent)
        {
           
            if (Stamina >= 9)          
            {
                opponent.Health -= Strength;
                Stamina -= 10;
                checkForWinner(opponent);
            }else
                Recharge();
            }

        public void checkForWinner(GameCharacter opponent)
        {
            if (opponent.Health <= 0)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($"{Name} is the winner");
                Console.WriteLine("---------------------------------------------------------------");
                isAlive = false;
            }
            else if (Health <= 0)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($"{opponent.Name} is the winner");
                Console.WriteLine("---------------------------------------------------------------");
                isAlive = false;
            }

        }
    
        public void Recharge()
        {
            if (Stamina <= 0)
            {
                Stamina = OrigonalStamina;
            }
            
        }
        public void InitStrength(GameCharacter Bowser)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 30);
            Bowser.Strength = num;
        }


    }


}
