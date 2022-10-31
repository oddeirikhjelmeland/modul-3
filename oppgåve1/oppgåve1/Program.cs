using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Uke_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        double totaltext = text.Length;
                        double hundre = 100;
                        double total = counts[i];
                        double Percent = (total / totaltext) * hundre;

                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i] + " " + Convert.ToInt16(Percent) + "%");
                    }
                }
            }

        }
    }
}
