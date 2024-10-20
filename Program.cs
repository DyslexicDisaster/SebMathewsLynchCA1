using SebMathewsLynchCA1.Classes;
using SebMathewsLynchCA1.Utilities;

namespace SebMathewsLynchCA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RaceEvent> raceEvents = new List<RaceEvent>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Horse Racing Management System");
                Console.WriteLine("1. Create Race Event");
                Console.WriteLine("2. Add Race to Event");
                Console.WriteLine("3. Add Horse to Race");
                Console.WriteLine("4. Display Events");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Call method to create race event
                        break;
                    case "2":
                        // Call method to add race to event
                        break;
                    case "3":
                        // Call method to add horse to race
                        break;
                    case "4":
                        // Call method to display events
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
