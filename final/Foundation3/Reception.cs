/*
Subclass of Event. Handles reception events. Uniquely formats an email.
*/
public class Reception : Event
{
    // attribute - unique to Reception
    private string _email;

    // constructor - derived from base
    public Reception(string title, string description, string date, string time, string address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    // method
    public void DisplayFullDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine($"{_email}");
    }
}