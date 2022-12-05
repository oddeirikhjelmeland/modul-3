using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    internal class StudentClass
    {
       
        public string Name { get; set; }
        public int StudentID { get; set; }

        public StudentClass(string name, int studentID)
        {
            Name = name;
            StudentID = studentID;
        }

        


    }
}
