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
        string testQuestion = "";
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(GLOBAL_SYNC_DELAY);
        Console.Clear();

        for(int i = _duration/5; i > 0; i--)
        {
            
            if(testQuestion != "ABORT:EMPTY")
            {
                testQuestion = DisplayQuestion();
                ShowSpinner(GLOBAL_SYNC_DELAY);
                Console.WriteLine();
            }
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        return _prompts[random.Next(0, _prompts.Count())];
    }
    public string GetRandomQuestion()
    {
        string question = "ABORT:EMPTY";
        int idx = random.Next(0, _questions.Count());

        if(_questions.Count() != 0)
        {
            question = _questions[idx];
            _questions.RemoveAt(idx);
        }

        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
    }
    public string DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
        return question;
    }
}