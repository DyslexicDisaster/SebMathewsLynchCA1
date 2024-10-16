using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebMathewsLynchCA1.Classes
{
    public class Race : Event
    {
        public DateTime StartTime { get; set; }
        public List<Horse> Horses { get; set; }

        public Race(string name, DateTime startTime) : base(name, "N/A") 
        {
            StartTime = startTime;
            Horses = new List<Horse>();
        }

        // Override to display race details
        public override void DisplayDetails()
        {
            Console.WriteLine($"Race: {Name}, Start Time: {StartTime}");
            foreach (var horse in Horses)
            {
                Console.WriteLine($"  Horse: {horse.Name}");
            }
        }

        // Add a horse to the race
        public void AddHorse(Horse horse)
        {
            Horses.Add(horse);
        }
    }
}
