using System;

public class ListingActivity: Activity
{
    Random random = new Random();
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = new List<string>();
        _prompts = prompts;
    }
    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine($"You listed {GetListFromUser().Count()} items!\n");
    }
    public void GetRandomPrompt()
    {
        Console.WriteLine($" --- {_prompts[random.Next(0, _prompts.Count())]} --- ");
    }
    public List<string> GetListFromUser()
    {
        List<string> strings = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(currentTime < futureTime)
        {
            Console.Write(">");
            strings.Add(Console.ReadLine());
            
            currentTime = DateTime.Now;
        }
        return strings;
    }
}