using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrePåRad
{
    internal class BoardView
    {
        public static void Show()
        {
            Console.WriteLine(" a b c");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine("1│o    │");
            Console.WriteLine("2│    o│");
            Console.WriteLine("3│× ×  │");
            Console.WriteLine(" └─────┘");
        }

    }
}
