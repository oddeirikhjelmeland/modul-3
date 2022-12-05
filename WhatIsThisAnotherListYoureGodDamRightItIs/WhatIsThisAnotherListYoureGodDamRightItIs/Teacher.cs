using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsThisAnotherListYoureGodDamRightItIs
{
    internal class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public bool IsTeacher { get; set; }
    
        public Teacher(int teacherId, string name, bool isTeacher)
        {
            TeacherId = teacherId;
            Name = name;
            IsTeacher = isTeacher;
        }

        public void TeacherInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {TeacherId}");
            Console.WriteLine($"Is a student: {IsTeacher}");
            Console.WriteLine("_________________________-");
        }
    }


}
