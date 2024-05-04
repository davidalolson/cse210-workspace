using System;

class Program
{
    static void Main(string[] args)
    {
        // set up prompt list
        PromptGenerator promptGenerator = new PromptGenerator();
        
        promptGenerator._promptList = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?",
            "What made me laugh today?",
            "Did I try something new today? What was it?",
            "What am I grateful for today?",
            "What is my goal for tomorrow?"
        ];

        // set up journal class
        Journal journal = new Journal();

        while(true)
        {
            // utilize entry class
            Entry entry = new Entry();

            // get a new prompt
            entry._promptText = promptGenerator.GetRandomPrompt();

            // IO
            Console.WriteLine(entry._promptText);
            entry._entryText  = Console.ReadLine();

            // get date
            DateTime theCurrentTime = DateTime.Now;
            entry._date = theCurrentTime.ToShortDateString();

            // add entry to journal
            journal._entryList.Add(entry);


        }
        




        





    }
}