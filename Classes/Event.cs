namespace SebMathewsLynchCA1.Classes;

public abstract class Event
{
    public string Name { get; set; }
    public string Location { get; set; }

    public Event(string name, string location)
    {
        Name = name;
        Location = location;
    }

    // Abstract method for displaying details
    public abstract void DisplayDetails();
}

