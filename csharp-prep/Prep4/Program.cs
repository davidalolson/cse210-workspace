using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        List<int> numbers = new List<int>(); // set up list with new instance

        int sum = 0; // init to 0
        int largestNumber = 0; // init to 0


        int userInput = 1; // init to any non zero int

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (userInput != 0)
        {
            // UI
            Console.Write("Enter number: ");
            string rawUserInput = Console.ReadLine();

            // Parse
            userInput = int.Parse(rawUserInput);

            // Add to list
            numbers.Add(userInput);
        }

        // Calculate sum and largest number
        foreach(int number in numbers)
        {
            sum += number;
            if (largestNumber < number)
            {
                largestNumber = number;
            }
        }
        
        // IO
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(double)sum/(numbers.Count-1)}"); // adding double ensures floating point value
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}