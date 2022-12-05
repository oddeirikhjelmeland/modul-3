using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsThisAnotherListYoureGodDamRightItIs
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStudent { get; set; }

        public Student(int id, string name, bool isStudent)
        {
            Id = id;
            Name = name;
            IsStudent = isStudent;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Is a student: {IsStudent}");
            Console.WriteLine("_________________________-");
        }
    }

}
