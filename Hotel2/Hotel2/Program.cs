namespace Hotel2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hotell mittHotell = new Hotell("Tower_Thomas");
            Gjest gjest = new Gjest("Anders");
            mittHotell.Booking(gjest, mittHotell.Roms[1]);
            ReadLine();



        }
    }
}