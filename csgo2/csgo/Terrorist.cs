using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgo
{
    internal class Terrorist
    {
        public bool IsDead { get; set; }
        public int MembersAlive { get; set; }
        public bool FoundASite = false;
        public bool BombIsActive = false;
        public int plantBomb = 0;

        public Terrorist(bool isDead, int membersAlive)
        {
            IsDead = isDead;
            MembersAlive = membersAlive;
        }
       
        public void FindBombSite(Terrorist Terrorist)
        {
            if (Character.IsSuccessful(10) == true && Terrorist.MembersAlive >0)
            {
                FoundASite = true;
                Console.WriteLine("The terrorist found bomb site A!");
            }
        }

        public void KillCounterTerrorist(CounterTerrorist CounterTerrorist, Terrorist Terrorist)
        {
            if (Character.IsSuccessful(7) == true && CounterTerrorist.MembersAlive > 0 && Terrorist.MembersAlive >0)
            {
                CounterTerrorist.MembersAlive--;
                Console.WriteLine("A CT has been killed");
            }
            if (CounterTerrorist.MembersAlive == 0)
            {
                Program.gameIsRunning = false;
                Console.WriteLine("All CT is dead, Terrorist won");
            }
        }

        public void PlantBomb(Terrorist Terrorist)
        {
            if ( !BombIsActive && FoundASite == true && Terrorist.MembersAlive > 0 )
            {
                if (plantBomb < 5)
                {
                    plantBomb++;
                    Console.WriteLine($"Terrorist are planting the bomb {plantBomb}/5");
                }
                else
                {
                    // bomb ++ if bomb = 5 it is planted
                    BombIsActive = true; // 15 rounds to complete
                    Console.WriteLine("The bomb has been planted");
                }
            }
        }
        public void TickingBomb()
        {
            if (BombIsActive)
            {
                if (Character.counter > 0)
                {
                    Character.counter--;
                    Console.WriteLine("Bomb is ticking: " + Character.counter);
                }else
                {
                    Console.WriteLine("Bomb has exploded, Terrorist wins");
                    Program.gameIsRunning = false;
                }
            }
        }
        public void PrintAlive(Terrorist Terrorist)
        {
            Console.WriteLine("T alive: " + Terrorist.MembersAlive);
        }
    }
}
