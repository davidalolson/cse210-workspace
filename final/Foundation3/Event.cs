/*
Superclass of events. Contains shared information for each event type.
*/
public class Event
{
    // attributes - essential event details, common to all sub-events
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    // constructor - base
    public Event(string title, string description, string date, string time, string address)
    // initialize values
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // methods
    public void DisplayStandardDetails()
    // display essential details to console only
    {
        Console.Write($"---{_title}--- \n{_description}\n\n{_date} at {_time}\n{_address}");
    }
    public void DisplayShortDescription()
    // display abbreviated details to console
    {
        Console.WriteLine($"{GetType()}: {_title} on {_date}");
    }
}