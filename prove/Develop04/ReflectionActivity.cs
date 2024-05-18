using System;
using System.Runtime.InteropServices;

class ReflectionActivity : Activity
{
    Random random = new Random();
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectionActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = new List<string>();
        _prompts = prompts;

        _questions = new List<string>();
        _questions = questions;
    }
    public void Run()
    {
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        for(int i = _duration/5; i > 0; i--)
        {
            DisplayQuestion();
            ShowSpinner(5);
            Console.WriteLine();
        }
    }
    public string GetRandomPrompt()
    {
        return _prompts[random.Next(0, _prompts.Count())];
    }
    public string GetRandomQuestion()
    {
        return _questions[random.Next(0, _questions.Count())];;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
    }
    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}