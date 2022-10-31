using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bossfight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] hero = { 100, 20, 40 };
             int[] boss = { 400, 20, 10 };*/
            int heroHealth = 100;
            int herostrength = 20;
            int heroStamina = 40;

            int bossHealth = 400;
            int bossStrength = 20;
            int bossStamina = 10;

            while (heroHealth > 0 && bossHealth > 0)
            {
                bossHealth = bossHealth - herostrength;
                Console.WriteLine("Hero hit the boss for " + herostrength + ",boss now has " + bossHealth + " health left.");
                heroStamina = heroStamina - 10;

                if (heroStamina > 0 || bossStamina > 0)
                {
                    heroHealth = heroHealth - bossStrength;
                    Console.WriteLine("the boss hit the hero for " + bossStrength + ", hero has " + heroHealth + " health left.");
                    bossStamina = bossStamina - 10;
                }
               else if (bossStamina > 0)
                {
                    heroHealth = heroHealth - bossStrength;
                    Console.WriteLine("the boss hit the hero for " + bossStrength + ", hero has " + heroHealth + " health left.");
                    bossStamina = bossStamina - 10;

                }
                              
                else if (bossStamina <= 0)
                {
                    Console.WriteLine("boss is recharging");
                    bossStamina = bossStamina + 10;
                }
                else if (heroStamina <= 0)
                {
                    Console.WriteLine("hero is recharging");
                    heroStamina = heroStamina + 10;
                } 
                
            }
            if (heroStamina <= 0)
            {
                Console.WriteLine("The hero has fallen");
            }
            else
            {
                Console.WriteLine("The hero stands victorious");
            }

            
            Console.ReadLine();

           
        }

        public void Fight()
        {
           

            return;

        }
        public void Recharge()
        {

        }
    }
}
