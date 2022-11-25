using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    internal class Worker
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public bool IsWorking { get; set; }
        public string WorkerPosition { get; set; }
        public Rooms Rooms { get; set; }
        public Customer Customer { get; set; }


        public Worker(int workerId,string workername, bool isWorking, string workerPosition)
        {
            WorkerId = workerId;
            WorkerName = workername;
            IsWorking = isWorking;
            WorkerPosition = workerPosition;
            Rooms = new Rooms();
            Customer = new Customer();
        }
        public Worker()
        {

        }

        public void CleanRoom()
        {
            if (Rooms.RoomCleaned = false && Customer.HasRoom == false)
            {
                Rooms.RoomCleaned = true;
            }else if (Customer.HasRoom == true)
            {
                Console.WriteLine("The room is currently occupied");
            }
        }


    }
}
