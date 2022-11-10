using bossfight;
using System;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hero and Boss fight! ");
        Console.WriteLine("---------------------------------------------------------------");

        //hero player
        GameCharacter Mario = new(100, 55, 40, "Mario");

        //boss player
        GameCharacter Bowser = new(400, 1, 10, "Bowser");

        //for og se om vardiene er riktige
      
        int round = 0;
        while (GameCharacter.isAlive)
        {
            round++;
           
            Console.WriteLine("Round " + round);
            Console.WriteLine("Mario hp " + Mario.Health + " stamina " + Mario.Stamina);
            Console.WriteLine("Bowser hp " + Bowser.Health + " stamina " + Bowser.Stamina);
            Console.WriteLine("---------------------------------------------------------------");
            Thread.Sleep(500);
            Mario.Fight(Bowser);
            Bowser.Fight(Mario);
           
        }
   
 

    }
}
/*
 
Gamecharacter Link = new("Link", 350, 20, 20);
Gamecharacter Ganon = new("Ganon", 250, 20, 20);

  
  
 while (Gamecharacter.IsAlive)
{
    Thread.Sleep(800);
    Ganon.InitStrength(Ganon);
    Link.Fight(Ganon);
    Ganon.Fight(Link);
}


------------------------------------------




namespace Deleteme_Bossfight
{
    internal class Gamecharacter
    {
        public static bool IsAlive = true;
        private string _name { get; set; }
        private int _health { get; set; }
        private int _stamina { get; set; }
        private int _strength { get; set; }
        private Random r { get; set; }
        private int _originalStamina;
        public Gamecharacter(string name, int health, int stamina, int strength)
        {
            _name = name;
            _health = health;
            _stamina = stamina;
            _strength = strength;
            _originalStamina = stamina;

        }
        
        public void Fight(Gamecharacter enemy)
        {
            if(_stamina > 9)
            {
                enemy._health -= _strength;
                _stamina -= 10;
                WriteLine($"{this._name} hits {enemy._name} with {this._strength} damage, {enemy._name} has {enemy._health}hp left");
                WriteLine("|");
                CheckForAWinner(enemy);
            }
            else
            {
                Recharge();
            }
        }

        public void Recharge()
        {
            _stamina = _originalStamina;
            WriteLine($"{this._name} Recharged back to {this._originalStamina}");
            WriteLine("*");

        }

        public void CheckForAWinner(Gamecharacter enemy)
        {
            if (enemy._health <= 0)
            {
                WriteLine($"{_name} is the winner !");
                IsAlive = false;
            }
            else if (_health <= 0)
            {
                WriteLine($"{enemy._name} is the winner !");
                IsAlive = false;
            } 
        }

        public void InitStrength(Gamecharacter ganon)
        {
            Random random = new Random();
            ganon._strength = random.Next(50);
            
        }






      


    }
}

 */