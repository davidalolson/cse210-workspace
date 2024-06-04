/*
Subclass of Event. Handles outdoor events. Uniquely reports weather information.
*/
public class Outdoor : Event
{
    // attribute - unique to Outdoor
    private string _weather;

    // constructor - derived from base
    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    // method
    public void DisplayFullDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"\nPredicted Weather Conditions: {_weather}");
    }
}