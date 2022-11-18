using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bossFightWithList
{
    internal class GameCharacter
    {
        public static bool isAlive = true;
        public string Name { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }

        public int Attack { get; set; }

        public int startStamina;

        public GameCharacter(string name, int health, int stamina, int attack)
        {
            Name = name;
            Health = health;
            Stamina = stamina;
            Attack = attack;
            startStamina = Stamina;
        }

        public void Fight(GameCharacter theOtherOne)
        {
            if (Stamina >= 9)
            {
                theOtherOne.Health -= Attack;
                Stamina -= 10;
                isDead(theOtherOne);
            }
            else
            {
                Recharge();

            }
        }

        public void Recharge()
        {
            if (Stamina <= 0)
            {
                Stamina = startStamina;

            }
        }
        public void isDead(GameCharacter theOtherone)
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} is dead");
                isAlive = false;
            }
            else if (theOtherone.Health <= 0)
            {
                Console.WriteLine($"{theOtherone.Name} is dead");
                isAlive = false;
            }
        }
    }
}
