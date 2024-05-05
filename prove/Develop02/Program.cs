using System;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

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

        // set up directory class
        Directory directory = new Directory();
        directory.AddToDirectory("Directory:");

        // set up journal class
        Journal journal = new Journal();

        // define commands
        List<string> menuOption = ["Write", "Display", "Load", "Save", "Quit"];
        int userCmd = 0; 

        // welcome text
        Console.WriteLine("Welcome to the Journal Program!");

        while(userCmd != 5)
        {
            // menu
            Console.WriteLine("Please select one of the following choices");
            
            // print out commands
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}. {menuOption[i]}");
            }
            
            // IO
            Console.Write("What would you like to do?: ");
            userCmd = int.Parse(Console.ReadLine());

            

            if(userCmd != 5)
            {
                if(userCmd == 1)
                {
                    // utilize entry class
                    Entry entry = new Entry();

                    // get a new prompt
                    entry._promptText = promptGenerator.GetRandomPrompt();

                    // IO
                    Console.WriteLine(entry._promptText);
                    Console.Write("\n> ");
                    entry._entryText  = Console.ReadLine();

                    // get date
                    DateTime theCurrentTime = DateTime.Now;
                    entry._date = theCurrentTime.ToShortDateString();

                    // add entry to journal with AddEntry meathod
                    journal.AddEntry(entry);    
                }
                if(userCmd == 2)
                {
                    // display journal
                    journal.DisplayAll();
                }
                if(userCmd == 3)
                {
                    // load from file routine

                    directory.Display();

                    Console.Write("Please speacify the file to load: ");
                    Console.Write("\n> ");

                    string fileName = Console.ReadLine();
                    
                    journal.LoadFromFile(fileName);

 
                }
                if (userCmd == 4)
                {
                    // save to file routine
                    Console.Write("Please enter a filename for this journal: ");
                    Console.Write("\n> ");
                    string fileName = Console.ReadLine();
                    
                    directory.AddToDirectory(fileName);
                    journal.SaveToFile(fileName);
                }
            }

        }
        




        





    }
}