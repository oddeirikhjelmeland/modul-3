using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballgame3
{
    internal class Game
    {

        ConsoleKeyInfo pressedKey = Console.ReadKey();

        internal static void MovingObject(Action test)
        {
            throw new NotImplementedException();
        }

        public void MovingObject()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 10);
            Console.Write("O");
            Thread.Sleep(50);
            Movement.MoveBallRight(0,+1,+1,25,10);

        }

    }
}

