namespace ListPugging1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var liste = new List<int>();
            var minListe = new List<Temp>(); // [null, null,null,null]
            Console.WriteLine("hei");
            Console.WriteLine(1);
            minListe.Add(new Temp()); // [ Temp(), null,null,null] ==> Temp har TallListe = [null, null,null,null]
            minListe[0].TallListe.Add(1); // [ Temp(), null,null,null] ==> Temp har TallListe = [1, null,null,null]

            minFunksjon(1);
            minFunksjon("Hei");
            minFunksjon(new Temp());
        }
        static void minFunksjon(int tall)
        {

        }

        static void minFunksjon<T>(T tall)
        {

        }

        static void minFunksjon(string tekst)
        {

        }
    }
}


// Hotell som har
// - Gjester  == List<Gjest> 
// - Rom 
// - Ansatte 