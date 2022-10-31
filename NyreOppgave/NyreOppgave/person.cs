using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyreOppgave
{
    internal class person
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool HealthyKidney { get; set;}  

            public Person(string name, int age, bool healthyKidney)
            {
                Name = name;
                Age = age;
                HealthyKidney = healthyKidney;

            }
            //public void KidneyUpdate(bool updateKidney)
            //{
            //    HealthyKidney = updateKidney;
            //}
        }
    }
}
