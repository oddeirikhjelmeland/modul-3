using csgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csgo
{
    internal class CounterTerrorist
    {
        public bool IsDead { get; set; }
        public int MembersAlive { get; set; }
        public int defuse = 0;

        public CounterTerrorist(bool isDead, int membersAlive) 
        {
            IsDead = isDead;
            MembersAlive = membersAlive;
        }
  
        public void KillTerrorist(Terrorist Terrorist)
        {
            if (Terrorist.BombIsActive && Terrorist.MembersAlive > 0)
            {
                if (Character.IsSuccessful(3) == true)
                {
                    Terrorist.MembersAlive--;
                    Console.WriteLine("A terrorist has been killed");
                }
            }
            else
            {
                if (Character.IsSuccessful(5) == true && Terrorist.MembersAlive > 0)
                {
                    Terrorist.MembersAlive--;
                    Console.WriteLine("A terrorist has been killed");
                }
                else if (!Terrorist.BombIsActive && Terrorist.MembersAlive == 0)
                {
                        Program.gameIsRunning = false;
                        Console.WriteLine("All T are dead, CT wins");
                    
                }
            }
        }
        public void DefuseBomb(Terrorist Terrorist, CounterTerrorist CounterTerrorist)
        {
            if (Terrorist.MembersAlive == 0 && Terrorist.BombIsActive == true)
            {
                defuse++;
                Console.WriteLine("CT is defusing: " + CounterTerrorist.defuse);
                if (defuse == 5)
                {
                    Program.gameIsRunning = false;
                    Console.WriteLine("CT defused the bomb. CT won");
                }
            }

        }
        public void PrintAlive(CounterTerrorist CounterTerrorist)
        {
            Console.WriteLine("CT alive: " + CounterTerrorist.MembersAlive);
        }

    }
}
