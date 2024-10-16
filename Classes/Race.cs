using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebMathewsLynchCA1.Classes
{
    public class Race : Event, IHorseManager
    {
        public DateTime StartTime { get; set; }
        public List<Horse> Horses { get; set; }

        public Race(string name, DateTime startTime) : base(name, "N/A") 
        {
            StartTime = startTime;
            Horses = new List<Horse>();
        }
        
        public override void DisplayDetails()
        {
            Console.WriteLine($"Race: {Name}, Start Time: {StartTime}");
            foreach (var horse in Horses)
            {
                Console.WriteLine($"  Horse: {horse.Name}");
            }
        }
        
        public void AddHorse(Horse horse)
        {
            Horses.Add(horse);
        }
    }
}
