/*
Subclass of Event. Handles lecture events. uniquely reports speaker and capacitance.
*/
public class Lecture : Event
{
    // attributes - unique to Lecture
    private string _speaker;
    private int _capacity;

    // constructor - derived from base
    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // method
    public void DisplayFullDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"\nSpeaker: {_speaker}! -:- Max Capacity: {_capacity} people");
    }
}