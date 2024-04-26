using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        // IO
        DisplayWelcome();

        string getName = PromptUserName();
        
        int getNumber = PromptUserNumber();
        
        int getSquare = SquareNumber(getNumber);
        
        DisplayResult(getName, getSquare);


        // Functions
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string rawNumber = Console.ReadLine();
            
            // Parse
            int number = int.Parse(rawNumber);

            return number;
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int squNum)
        {
            Console.WriteLine($"{name}, the square of your number is {squNum}");
        }
    }
}