
using System.Security.Cryptography;

namespace Ballgame3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);

            
            var test = new Game().MovingObject;

            while (true)
            {
                Game.MovingObject(test);
            }

            //int x = 25;
            //int y = 10;

            ////    int up = y--;
            ////    int down = y++;
            //int direction = 0;
            //int directionRight = +1;
            //int directionLeft  = -1 ;
            //Console.WriteLine("Press W,A,S, or D to start. Press any other key to quit.");
            //ConsoleKeyInfo pressedKey = Console.ReadKey();

            //while (true)
            //{
            //    if (pressedKey.Key == ConsoleKey.A)
            //    {
                   
            //        if (x <= 0)
            //        {
            //            x += directionRight;
            //            Console.WriteLine("3");
            //        }
            //        x += directionLeft;
            //        Console.WriteLine("1");

            //    }
            //    else if (pressedKey.Key == ConsoleKey.D)
            //    {
            //        x += directionRight;
            //        Console.WriteLine("2");

            //    }
              
            //    else if (x >= 50)
            //    {
            //        x = directionLeft;
            //        Console.WriteLine("4");
            //    }

               
            //    Console.Clear();
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("O");
            //    Thread.Sleep(50);
                //if (y <= 0)
                //{
                //    y = 0;
                //    y = down;
                //}
                //else if (y >= 20)
                //{
                //    y = y - 1;
                //}


                //else if (pressedKey.Key == ConsoleKey.S)
                //{
                //    y =y+1;
                //}
                //else if (pressedKey.Key == ConsoleKey.W)
                //{
                //    y = y-1;
                //}
                //else { break; }
            }
        }
    }
}

/*
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
}*/