using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    internal class Student
    {
        public List<Student> Students { get; set; }

        public Student()
        {
            Students = new List<Student>();
        }

        public void AddStudents()
        {
            Students.Add(new Student("Odd", 001));
            Students.Add(new Student("Truls", 002));
        }
    }
}
