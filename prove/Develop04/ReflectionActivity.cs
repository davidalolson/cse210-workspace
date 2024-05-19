using System;
using System.Runtime.InteropServices;

// child class
class ReflectionActivity : Activity
{
    // class instance
    Random random = new Random();
    
    // attributes
    private List<string> _prompts;
    private List<string> _questions;

    private List<int> _questionHistory;

    // use base constructor with additional prompts and questions parameters
    public ReflectionActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = new List<string>();
        _prompts = prompts;

        _questions = new List<string>();
        _questions = questions;

        _questionHistory = new List<int>();
    }

    // methods
    public void Run()
    {
        string testQuestion = "";   // use to detect if every question in _questions has been asked
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
            
            if(testQuestion != "ABORT:EMPTY")   // stop if out of questions
            {
                testQuestion = DisplayQuestion();
                ShowSpinner(GLOBAL_SYNC_DELAY);
                Console.WriteLine();
            }
        }

        _questionHistory.Clear();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        return _prompts[random.Next(0, _prompts.Count())];
    }
    public string GetRandomQuestion()
    {
        string question = "ABORT:EMPTY";

        int idx = random.Next(0, _questions.Count());       // logic to ensure that each question is only asked once

        if(_questionHistory.Count() < _questions.Count())
        {
            while(_questionHistory.Contains(idx))
            {
                idx = random.Next(0, _questions.Count());
            }

            question = _questions[idx];
            _questionHistory.Add(idx);
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