
using System.Security.Cryptography;

namespace Ballgame3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);
            int x = 25;
            int y = 10;
            Console.WriteLine("Press W,A,S, or D to start. Press any other key to quit.");
            ConsoleKeyInfo pressedKey = Console.ReadKey();

            while (true)
            {
                Random wallBounceHor = new Random();
                Random wallBounceVert = new Random();
                int a = wallBounceHor.Next(1, 20);
                int b = wallBounceVert.Next(1, 50);
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("O");

               if (x <= 0){x = b;}
                else if (x >= 50){x = b;}
               if (y <= 0){y = a;} 
                else if (y >= 20){ y = a;}
              
                if (pressedKey.Key == ConsoleKey.A)
                {
                    x--;
                    pressedKey = Console.ReadKey();

                }else if (pressedKey.Key == ConsoleKey.D)
                {
                    x++;
                    pressedKey = Console.ReadKey();
                }else if (pressedKey.Key == ConsoleKey.S)
                {
                    y++;
                    pressedKey = Console.ReadKey();
                }
                else if (pressedKey.Key == ConsoleKey.W)
                {
                    y--;
                    pressedKey = Console.ReadKey();
                }
                else { break; }
            }
        }
    }
}