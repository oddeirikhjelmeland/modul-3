﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Student
    {
        public string Name;
        public string major;
        public double gpa;


        public Student(string aName, string aMajor, double aGpa)
        {
            Name = aName;
            major = aMajor;
            gpa = aGpa;  
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
