﻿namespace SebMathewsLynchCA1.Classes;

public class RaceEvent : Event, IRaceManager
{
    public List<Race> Races { get; set; }
    public int raceCount;

    public RaceEvent(string name, string location) : base(name, location)
    {
        Races = new List<Race>();
        raceCount = 0;
    }
    
    public void AddRace(Race race)
    {
        raceCount++;
        
        
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