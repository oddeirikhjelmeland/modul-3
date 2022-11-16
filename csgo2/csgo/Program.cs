namespace csgo
{
    internal class Program
    {
       public static bool gameIsRunning = true;
       

        static void Main(string[] args)
        {
            Terrorist Terrorist = new (false, 5);

            CounterTerrorist CounterTerrorist = new (false, 5);
            

            while (gameIsRunning)
            {
                Terrorist.PrintAlive(Terrorist);
                CounterTerrorist.PrintAlive(CounterTerrorist);
                Thread.Sleep(1000);
                Terrorist.TickingBomb();
                Terrorist.FindBombSite(Terrorist);
                Terrorist.PlantBomb(Terrorist);
                Terrorist.KillCounterTerrorist(CounterTerrorist, Terrorist);
                CounterTerrorist.KillTerrorist(Terrorist);
                CounterTerrorist.DefuseBomb(Terrorist, CounterTerrorist);
                 
                // Terrorist.PrintPeopleAlive();
               
            }
        }
    }
}