using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    public class Player
    {
        public string Name { get; private set; }
        public int Points;

        public Player(string name, int points)
        {
            Name = name;
            Points = points;

        }


        internal void Play(Player player2)
        {
            player2.Points++;
            Points--;
        }

        internal void ShowNameAndPoints()
        {
            Console.WriteLine("Name: " + Name + " - " + Points);
        }

    }
}
