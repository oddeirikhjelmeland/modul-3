namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int pin = 1234;

            //Console.WriteLine("Skriv in koden til låsen");
            //int input = Convert.ToInt32(Console.ReadLine());
            //if (input == pin)
            //{
            //    Console.WriteLine("Koden var rikting");
            //}
            //else
            //{
            //    Console.WriteLine("Koden var feil");
            //}
            // pinkode som e riktig
            // readline som tar user input
            // method som sjekke om dei er like

            Sykkel thiscanbecalledanyhting = new("test", false, "fdwa");
            Sykkel sykkel = new("skivebrems", true, "aluminium");

            thiscanbecalledanyhting.Kodelås.ÅpneKodeLås();
            
      
        }
    }
}

// skriv inn kode

// 1234

// gratulerer



//   sykkel:
//   {
//    kodelås: { riktig: 4321, antallSiffer: 4},
//    hjul: { antallEiker: 30, dimensjon: 20 },
//    bremser: "skivebrems",
//    refleks: true,
//    ramme: "aluminium",

//   },