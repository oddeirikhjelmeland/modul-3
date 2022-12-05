namespace WhatIsThisAnotherListYoureGodDamRightItIs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gona be a school with teachers and students I guess

            var School = new School();

            School.AddTeacher();
            School.AddStudent();
            School.PrintTeachers();
            Console.WriteLine("*****************");
            School.PrintStudents();
        }
    }
}