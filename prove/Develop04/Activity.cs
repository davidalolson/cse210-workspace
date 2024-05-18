using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"\n{_description}");
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        for(int i = 0; i < seconds*4; i++)
        {
            Console.Write($"{"|/-\\".Substring(i%4, 1)}\b");
            Thread.Sleep(250);
        }
        Console.Write(" \b");
    }
    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}\b");
            Thread.Sleep(1000);
        }
        Console.Write(" \b");
    }
}