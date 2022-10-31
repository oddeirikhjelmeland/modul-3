using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kidney
    {
        public bool Part1 { get; set; }
        public bool Part2 { get; set; }

        public Kidney(bool part1, bool part2)
        {
            Part1 = part1;
            Part2 = part2;
        }
        public string Print()
        {
            return "Part1 " + Part1 + " Part2 " + Part2;
            
        }
    }
}
