using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWithList
{
    internal class Rom
    {

        public int DoorNumber { get; set; }
        public Gjest Gjest { get; set; } 
        

        public Rom (int doorNumber)
        {
            DoorNumber = doorNumber;
        }

        public void AddGuestToRoom(Gjest gjest)
        {
            Gjest = gjest;
        }
    }
}
