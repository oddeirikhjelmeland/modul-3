using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsThisAnotherListYoureGodDamRightItIs
{
    internal class School
    {
        public List<Student> Students;
        public List<Teacher> Teachers;

        public School()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        public void AddStudent()
        {
            Students.Add(new Student(001, "Odd", true));
            Students.Add(new Student(002, "Eirik", true));
        }

        public void AddTeacher()
        {
            Teachers.Add(new Teacher(101, "Joakim", true));
            Teachers.Add(new Teacher(102, "Therese", true));
        }

        public void PrintStudents()
        {
            foreach(var student in Students)
            {
                student.StudentInfo();
            }
        }
        public void PrintTeachers()
        {
            foreach(var teacher in Teachers)
            {
                teacher.TeacherInfo();
            }
        }
    }
   
}
