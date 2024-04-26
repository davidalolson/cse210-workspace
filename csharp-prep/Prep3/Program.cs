using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        string ui = "yes";

        // Master loop
        while (ui == "yes")
        {
            // Variables
            int userGuess = 0; // ui init to 0
            int countGuess = 0; // counter init to 0

            // Random element
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100); 

            // Subroutine loop
            while (userGuess != magicNumber)
            {
                // IO
                Console.Write("What is your guess? ");
                string rawUserGuess = Console.ReadLine();

                // Increment counter
                countGuess++;

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

            // Game over
            Console.WriteLine($"You guessed it in {countGuess} attempts!");
            Console.Write("Would you like to play again? ");
            ui = Console.ReadLine();
        }
    }
}