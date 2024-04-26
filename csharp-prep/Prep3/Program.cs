using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int userGuess = 0; // define init to 0

        // Random element
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100); 

        // Loop
        while (userGuess != magicNumber)
        {
        // IO
            Console.Write("What is your guess? ");
            string rawUserGuess = Console.ReadLine();

            // Parse     
            userGuess = int.Parse(rawUserGuess);

            // Hint logic
            if(magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if(magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}