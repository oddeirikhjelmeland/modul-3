namespace Hotel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rooms suite = new(true, "Honeymoon Suite", 1, true, 500, "Suite", 1, "King");
            Rooms family = new(true, "FamilyRoom", 2, true, 300, "Standard", 2, "Double");
            Rooms standard = new(true, "Standard Room", 3, false, 150, "Standard", 1, "double");

            Worker manager = new(001, "Jaiden", true, "Manager");
            Worker worker1 = new(002, "Alpharad", true, "Front desk");
            Worker worker2 = new(003, "Jon", false, "Cleaner");
            Worker worker3 = new(004, "Glenn", true, "Janitor");


            Customer customer1 = new("Jack", false, 100, false);
            Customer customer2 = new("Magnus", true, 101, false);




            /*
             WHAT DOES A HOTEL NEED
            --rooms
                -available
                -taken
                -different quality / cost

            --payments

            --cleaning
                -must be cleaned before becomming available

            --customers
                -new, current, removed when checked out
                

            --workers
                -id
                -posisiton
                -at work
             */
        }
    }
}