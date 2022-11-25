using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace listpugging
{
    public class Item
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Item(int id, string name)
        {
            Name = name;
            Id = id;

        }
    }
   
}
