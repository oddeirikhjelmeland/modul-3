using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong2
{
    internal class GetAcademy
    {
        public List<Lærer> Lærere;
        public List<Student> Studenter;
        public bool GetIsASchool = true;
        public string FargePåBygg { get; private set; } = "Hot Pink";
        public Kodelås kodelås;
        

        public GetAcademy()
        {
            FargePåBygg = "Hot Pink";
            Lærere = new List<Lærer>();
            Studenter = new List<Student>();
            kodelås = new Kodelås();
            AddStudents();
            AddTeacher();
        }
        private void AddStudents()
        {
            Studenter.Add(new Student("Erik", 345));
            Studenter.Add(new Student("Odd Eirik", 456));
        }
        private void AddTeacher()
        {
            var Joakim = new Lærer("Joakim", 3);
            Lærere.Add(Joakim);
            var Linn = new Lærer("Linn", 1);
            Lærere.Add(Linn);
        }

        public void ShowStudents()
        {
            foreach(var student in Studenter)
            {
                student.StudentInfo();
            }
        }
        

       // getAcademy.Kodelås.OpenLock();


        //    Studenter:[{ navn: "Erik", id: 345},{ navn: "Truls", id: 346},],
        //    Lærere:[{ navn: "Joakim", Modul: 3},{ navn: "Linn", Modul: 1},],
        //    Kodelås: { riktig: 1234, antallSiffer: 4},
        //    Skole: true,
        //    FargePåBygg: "Hot Pink",
    }
}
