using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWithList
{
    internal class Hotell
    {
        public string Name { get; set; }
        public List<Rom> Roms { get; set; }
        private List<Ansatt> _ansatte;
        private List<Gjest> _gjester;

        public Hotell(string name)
        {
            Name = name;
            Roms = new List<Rom>();
            _ansatte = new List<Ansatt>();
            _gjester = new List<Gjest>();
            MakeThreeRooms();
        }

        public void Booking (Gjest gjest, Rom rom)
        {
            gjest.Booking(rom);
            rom.AddGuestToRoom(gjest);
        }

        public void MakeThreeRooms()
        {
            Roms.Add(new Rom(100));
            Roms.Add(new Rom(101));
            Roms.Add(new Rom(102));
        }


    }
}
