namespace CodeAlong2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var getAcademy = new GetAcademy();
            getAcademy.kodelås.OpenLock();
            //getAcademy.AddStudents();
            getAcademy.ShowStudents();
            // getAcademy.FargePåBygg = "Grønn";
            Console.WriteLine(getAcademy.FargePåBygg);
        }
    }
}



// getAcademy:
//  {
//    Studenter:[{ navn: "Erik", id: 345},{ navn: "Truls", id: 346},],
//    Lærere:[{ navn: "Joakim", Modul: 3},{ navn: "Linn", Modul: 1},],
//    Kodelås: { riktig: 1234, antallSiffer: 4},
//    Skole: true,
//    FargePåBygg: "Hot Pink",
//  },