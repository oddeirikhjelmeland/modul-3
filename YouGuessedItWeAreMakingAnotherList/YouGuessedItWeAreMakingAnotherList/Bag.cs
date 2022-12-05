using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouGuessedItWeAreMakingAnotherList
{
    internal class Bag
    {
        public List<Weapon> Weapons;

        public Bag()
        {
            Weapons = new List<Weapon>();
        }

        public void AddWeapons()
        {
            Weapons.Add(new Weapon("Short Sword", "Sharp", 5));
            Weapons.Add(new Weapon("Big Mace", "Bludgening", 20));
            Weapons.Add(new Weapon("Dagger", "Piercing", 2));

        }

        public void PrintWeapons()
        {
            foreach(var weapon in Weapons)
            {
                weapon.Info();
            }
        }




    }
}
