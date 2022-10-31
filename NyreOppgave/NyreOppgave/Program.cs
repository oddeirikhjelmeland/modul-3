using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NyreOppgave.Program;

namespace NyreOppgave
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {

            var person1 = new person("Kåre");
            var person2 = new person("test2");
            var name = person1.Name;

            List<Person> listOfPeople = new List<Person>();
            listOfPeople.Add(person1);     // her legges Terje inn i en liste
            listOfPeople.Add(person2);    // her legges Marie inn i en liste
            foreach (Person person in listOfPeople) // Denne løkken går igjennom alle i listen og printer ut navnet dems
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadLine();
        }
    }
   
}
