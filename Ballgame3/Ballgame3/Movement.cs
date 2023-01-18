using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballgame3
{
    internal class Movement
    {
        public int Direction { get; set; }
        public int DirectionRight { get; set; }
        public int DirectionLeft { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        //public int Direction = 0;
        //public int DirectionRight = +1;
        //public int DirectionLeft = -1;
        //public int X = 25;
        //public int Y = 10;


        public Movement(int direction, int directionRight, int directionLeft, int x, int y)
        {
            Direction = direction;
            DirectionRight = directionRight;
            DirectionLeft = directionLeft;
            X = x;
            Y = y;
        }

        //static void MoveBall()
        //{
        //    MoveBallLeft();
        //}
        public void MoveBallRight()
        {
            X += DirectionRight;
            if (X <= 0)
            {
                MoveBallLeft();
            }
        }
         public  void MoveBallLeft()
        {
            X += DirectionLeft;
            if (X >= 50)
            {
                MoveBallRight();
            }
        }

        internal static void MoveBallRight(int v1, int v2, int v3, int v4, int v5)
        {
            throw new NotImplementedException();
        }
    }
}
