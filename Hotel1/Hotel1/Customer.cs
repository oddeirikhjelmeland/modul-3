using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    internal class Customer
    {
        public string Name { get; set; }
        public bool HasPaid { get; set; }
        public int ID { get; set; }
        public bool HasRoom { get; set; }


        public Customer(string name, bool hasPaid, int id, bool hasRoom)
        {
            Name = name;
            HasPaid = hasPaid;
            ID = id;
            HasRoom = hasRoom;
        }
        public Customer()
        {

        }
    }
}
