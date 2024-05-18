using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // global variables
        string userCmd = "";

        List<string> reflectionPrompts = new List<string>(["Think of a time when you stood up for someone else.",
                                                            "Think of a time when you did something really difficult.",
                                                            "Think of a time when you helped someone in need.",
                                                            "Think of a time when you did something truly selfless."]);

        List<string> reflectionQuestions = new List<string>(["Why was this experience meaningful to you?",
                                                                "Have you ever done anything like this before?",
                                                                "How did you get started?",
                                                                "How did you feel when it was complete?",
                                                                "What made this time different than other times when you were not as successful?",
                                                                "What is your favorite thing about this experience?",
                                                                "What could you learn from this experience that applies to other situations?",
                                                                "What did you learn about yourself through this experience?"]);
                                            
        List<string> listingPrompts = new List<string>(["Who are people that you appreciate?",
                                                            "What are personal strengths of yours?",
                                                            "Who are people that you have helped this week?",
                                                            "When have you felt the Holy Ghost this month?",
                                                            "Who are some of your personal heroes?"]);
                                                                                                                                                            

        while(userCmd != "4")
        {
            // menu sequence
            Console.WriteLine("Menu Options:\n    1. Start breathing activity\n    2. Start reflecting activity\n    3. Start listing activity\n    4. Quit");
            Console.Write("Select a choice from the menu: ");
            userCmd = Console.ReadLine();

            // breathing activity
            if(userCmd == "1")
            {
                // use inherited constructor to setup breathing activity
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                // begin breathing activity process
                breathingActivity.Run();
            }

            // reflection activity
            if(userCmd == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", reflectionPrompts, reflectionQuestions);
                reflectionActivity.Run();
            }

            // listing activity
            if(userCmd == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",listingPrompts);
                listingActivity.Run();
            }
        }
    }
}