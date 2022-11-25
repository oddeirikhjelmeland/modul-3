using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    internal class Rooms
    {
        public bool RoomAvailable { get; set; }
        public string RoomName { get; set; }
        public int RoomId { get; set; }
        public bool RoomCleaned { get; set; }
        public double RoomCost { get; set; }
        public string RoomQuality { get; set; }
        public int BedAmount { get; set; }
        public string BedType { get; set; }
        public Customer Customer { get; set; }


        public Rooms(bool roomAvailable, string roomName, int roomId, bool roomCleaned, double roomCost, string roomQuality, int bedAmount, string bedType)
        {
            RoomAvailable = roomAvailable;
            RoomName = roomName;
            RoomId = roomId;
            RoomCleaned = roomCleaned;
            RoomCost = roomCost;
            RoomQuality = roomQuality;
            BedAmount = bedAmount;
            BedType = bedType;
            Customer = new Customer();
          
        }
        public Rooms()
        {

        }


        public void RegristerRoom()
        {
            if (RoomAvailable = true && Customer.HasRoom == false)
            {
                // another if statement that gets what room they want.

            }
            else if (RoomAvailable = false && Customer.HasRoom == true)
            {
                Console.WriteLine("The costumer already has a room assigned");
            }else
            {
                Console.WriteLine("There are no rooms available");
            }
        }
    }
}
