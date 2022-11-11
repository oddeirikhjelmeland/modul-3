namespace BossFight4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameCharacter cola = new GameCharacter("Cola", 400, 30, 40);
            GameCharacter pepsi = new GameCharacter("Pepsi", 100,40,10);


            while (isAlive)
            {
                cola.fight(pepsi);
                pepsi.fight(cola);
            }
        }
    }
}