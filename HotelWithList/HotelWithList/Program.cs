namespace HotelWithList;
using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            Hotell mittHotell = new ("Pimpton");
            Gjest gjest = new ("Kåre");
            mittHotell.Booking(gjest, mittHotell.Roms[1]);
            ReadLine();
        }
    }
