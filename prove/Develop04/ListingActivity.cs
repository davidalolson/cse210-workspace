using System;

// child class
public class ListingActivity: Activity
{
    // class instance
    Random random = new Random();

    // attributes
    private int _count;
    private List<string> _prompts;
    
    // ues base constructor with additional prompts parameter
    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = new List<string>();
        _prompts = prompts;
    }

    // methods
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(GLOBAL_SYNC_DELAY);
        Console.WriteLine();
        Console.WriteLine($"You listed {GetListFromUser().Count()} items!\n");  // standard operation happens in this line

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Console.WriteLine($" --- {_prompts[random.Next(0, _prompts.Count())]} --- ");
    }
    public List<string> GetListFromUser()
    {
        List<string> strings = new List<string>();  // use to temporarily hold list

        // get time to allow real time tracking
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(currentTime < futureTime)
        {
            Console.Write(">");
            strings.Add(Console.ReadLine());
            
            currentTime = DateTime.Now; // check time again
        }
        return strings;
    }
}