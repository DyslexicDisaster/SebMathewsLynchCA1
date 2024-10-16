namespace SebMathewsLynchCA1.Classes;

public class RacingEvent : Event
{
    public List<Race> Races { get; set; }

    public RacingEvent(string name, string location) : base(name, location)
    {
        Races = new List<Race>();
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Race Event: {Name}, Location: {Location}");
        foreach (var race in Races)
        {
            race.DisplayDetails(); 
        }
    }
    
    public void AddRace(Race race)
    {
        Races.Add(race);
    }
}