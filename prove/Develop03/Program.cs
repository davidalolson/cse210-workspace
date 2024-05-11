using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // global variables
        string userKey = "";    // use for user input
        int numberOfWords = 1; 

        // Default scripture
        Reference reference = new Reference("Jacob",6,12);
        Scripture scripture = new Scripture(reference, "O be wise; what can I say more?");

        // main program
        while (userKey != "Escape")
        {   
            // switch scriptures
            if(userKey == "UpArrow")
            {
                numberOfWords = 1;
                reference = new Reference("Matthew", 22, 36, 39);
                scripture = new Scripture(reference, 
                    @"
                    Master, which is the great commandment in the law?

                    Jesus said unto him, Thou shalt love the Lord thy God with all 
                    thy heart, and with all thy soul, and with all thy mind.

                    This is the first and great commandment.

                    And the second is like unto it, Thou shalt love thy neighbour 
                    as thyself.
                    ");
            }
            // switch scriptures
            if(userKey == "DownArrow")
            {
                numberOfWords = 1;
                reference = new Reference("1 Nephi",3,7);
                scripture = new Scripture(reference, 
                    @"
                    And it came to pass that I, Nephi, said unto my father: I will go 
                    and do the things which the Lord hath commanded, for I know that the 
                    Lord giveth no commandments unto the children of men, save he shall 
                    prepare a way for them that they may accomplish the thing which he 
                    commandeth them.
                    ");

            }

            // Display scripture
            Console.Clear();    // clear console
            Console.WriteLine(scripture.GetDisplayText());  // display updated scripture
                                         
            Console.WriteLine("Press [Escape] to quit. Use arrow keys: \n      previous\n        [^]\nshow [<][V][>]  hide\n        next"); // display GUI
            userKey = Console.ReadKey().Key.ToString(); // get keypress

            // hide random words
            if(userKey == "RightArrow")
            {
                if(!scripture.IsCompletelyHidden())
                {
                    numberOfWords += 1; // increase the number of words hidden each time
                }

                scripture.HideRandomWords(numberOfWords); 
            }
            // show words
            if(userKey == "LeftArrow")
            {
                if(numberOfWords > 1)
                {
                    numberOfWords -= 1; // decrease the number of words to show each time
                }
                scripture.ShowPreviousWords(numberOfWords);
            }
        }
    }
}