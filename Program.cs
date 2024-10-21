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
                        CreateRaceEvent(raceEvents);
                        break;
                    case "2":
                        AddRaceToEvent(raceEvents);
                        break;
                    case "3":
                        AddHorseToRace(raceEvents);
                        break;
                    case "4":
                        ViewRaceEvents(raceEvents);
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
        static void CreateRaceEvent(List<RaceEvent> raceEvents)
        {
            string eventName = Validators.GetValidString("Enter Event Name: ");
            string location = Validators.GetValidString("Enter Location: ");
            int numberOfRaces = Validators.GetValidInteger("Enter Number of Races: ");

            RaceEvent newEvent = new RaceEvent(eventName, location);
            raceEvents.Add(newEvent);
            Console.WriteLine("Race event created successfully!");
        }
        static void AddRaceToEvent(List<RaceEvent> raceEvents)
        {
            string eventName = Validators.GetValidString("Enter the name of the race event: ");
            var raceEvent = raceEvents.FirstOrDefault(e => e.Name == eventName);
            if (raceEvent == null)
            {
                Console.WriteLine("Event not found!");
                return;
            }

            string raceName = Validators.GetValidString("Enter Race Name (or leave blank for default name): ");
            DateTime startTime = Validators.GetValidDate("Enter the start time of the race (e.g., 12/31/2024 14:00): ");
        
            Race newRace = new Race(raceName, startTime);
            raceEvent.AddRace(newRace);
            Console.WriteLine("Race added successfully!");
        }

        static void AddHorseToRace(List<RaceEvent> raceEvents)
        {
            string eventName = Validators.GetValidString("Enter the name of the race event: ");
            var raceEvent = raceEvents.FirstOrDefault(e => e.Name == eventName);
            if (raceEvent == null)
            {
                Console.WriteLine("Event not found!");
                return;
            }

            string raceName = Validators.GetValidString("Enter the race name: ");
            var race = raceEvent.Races.FirstOrDefault(r => r.Name == raceName);
            if (race == null)
            {
                Console.WriteLine("Race not found!");
                return;
            }

            string horseName = Validators.GetValidString("Enter Horse Name: ");
            DateTime dob = Validators.GetValidHorseDOB("Enter Horse Date of Birth (e.g., 01/01/2020): ");

            Horse newHorse = new Horse(horseName, dob);
            race.AddHorse(newHorse);
            Console.WriteLine("Horse added to race successfully!");
        }

        static void ViewRaceEvents(List<RaceEvent> raceEvents)
        {
            foreach (var raceEvent in raceEvents)
            {
                raceEvent.DisplayDetails();
            }
        }
    }
}
