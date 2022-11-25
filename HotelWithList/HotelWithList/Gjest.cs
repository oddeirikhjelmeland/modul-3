using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWithList
{
    internal class Gjest
    {
        public string Name { get; set; }
        public List<Rom> Roms { get; set; }

        public Gjest (string name)
        {
            Name = name;
            Roms = new List<Rom>();
        }

        public void Booking (Rom rom)
        {
            Roms.Add(rom);
        }
    }
}
