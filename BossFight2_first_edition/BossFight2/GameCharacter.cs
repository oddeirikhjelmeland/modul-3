using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bossfight
{
    internal class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }


        public static void Fight(GameCharacter hero, GameCharacter boss)
        {
            Random rnd = new Random();
            int num = rnd.Next(0,30);
            boss.Strength = num;
            if (hero.Stamina > 0 && boss.Stamina > 0)
            {
                boss.Health -= hero.Strength;
                hero.Health -= boss.Strength;
                hero.Stamina -= 10;
                boss.Stamina -= 10;
               // Recharge(boss, hero);
                Console.WriteLine("if statement 1");
            }
            else if (hero.Stamina <=0 && boss.Stamina <= 0)
            {
                Recharge(hero, boss);
                Console.WriteLine(" ");
                Console.WriteLine("if statement 2 : recharge time");
                Console.WriteLine(" ");
            }
            else if (hero.Stamina > 0 && boss.Stamina <= 0)
            {
                boss.Health -= hero.Strength;
                hero.Stamina -= 10;
                Recharge(hero, boss);
                Console.WriteLine(" if statement 3");
            }
            else if (hero.Stamina <= 0 && boss.Stamina > 0)
            {
                hero.Health -= boss.Strength;
                boss.Stamina -= 10;
                Recharge(hero, boss);
                Console.WriteLine("if statement 4");
            }
        }

        public static void Recharge(GameCharacter hero, GameCharacter boss)
        {
            if (hero.Stamina <= 0 && boss.Stamina  > 0)
            {
                hero.Stamina += 40;
            }
            else if (boss.Stamina <= 0 && hero.Stamina <= 0)
            {
                hero.Stamina += 40;
                boss.Stamina += 10;
            }
            else if (boss.Stamina <= 0 && hero.Stamina >0)
            {
                boss.Stamina += 10;
            }
        }

        public GameCharacter(int health, int strength, int stamina, string name)
        {

            Health = health;
            Strength = strength;
            Stamina = stamina;
            Name = name;
        }
    }


}
