namespace SebMathewsLynchCA1.Classes;

public class RaceEvent : Event, IRaceManager
{
    public List<Race> Races { get; set; }
    
    public RaceEvent(string name, string location) : base(name, location)
    {
        Races = new List<Race>();
    }
    //This method is for adding a new race
    public void AddRace(string raceName, DateTime startTime)
    {
        if (string.IsNullOrWhiteSpace(raceName))
        {
            raceName = $"Race {Races.Count + 1}";
        }

        Race newRace = new Race(raceName, startTime);
        Races.Add(newRace);  // Add race to the list
        Console.WriteLine($"Added {raceName} to event '{Name}'");
    }
    
    //This method is for adding an existing race
    public void AddRace(Race race)
    {
        if (race != null)
        {
            Races.Add(race);  
            Console.WriteLine($"Added existing race '{race.Name}' to event '{Name}'");
        }
        else
        {
            Console.WriteLine("Cannot add a null race.");
        }
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Race Event: {Name}, Location: {Location}");
        foreach (var race in Races)
        {
            race.DisplayDetails(); 
        }
    }
}