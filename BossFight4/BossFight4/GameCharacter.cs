using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight4
{
    internal class GameCharacter
    {
        public  bool isAlive = true;
        public string Name { get; set; }    
        public int Attack { get; set; }
  
        public int Health { get; set; }

        public int Stamina { get; set; }
        public int OgStamina;


        public GameCharacter  (string name, int attack, int health, int stamina)
        {
            Name = name;
            Attack = attack;    
            Health = health;    
            Stamina = stamina;
            OgStamina = Stamina;
        }

        public void Fight(GameCharacter OtherCharacter)
        {

            while (Stamina > 9)
            {
                Health -= OtherCharacter.Attack;
                Stamina -= 10;
            }

        }


    }
}
