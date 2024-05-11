using System;

class Program
{
    static void Main(string[] args)
    {
        string userKey = "";
        int numberOfWords = 1;

        // Jacob 6:12 O be wise; what can I say more?
        Reference reference1 = new Reference("Jacob",6,12);
        Scripture scripture1 = new Scripture(reference1, "O be wise; what can I say more?");

        // Omni 1:8-9

        Reference reference2 = new Reference("Omni",1,8,9);
        Scripture scripture2 = new Scripture(reference2, 
            @"
            And it came to pass that I did deliver the plates unto my brother Chemish.
            
            Now I, Chemish, write what few things I write, in the same book with my brother; 
            for behold, I saw the last which he wrote, that he wrote it with his own hand; and 
            he wrote it in the day that he delivered them unto me. And after this manner we 
            keep the records, for it is according to the commandments of our fathers. And I 
            make an end.
            ");
            
        while (userKey != "Escape" && !scripture2.IsCompletelyHidden())
        {
            // Display scripture
            Console.Clear();
            Console.WriteLine(scripture2.GetDisplayText());
                                         
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.WriteLine(numberOfWords);
            userKey = Console.ReadKey().Key.ToString();

            

            // hide random words
            if(userKey == "RightArrow")
            {
                scripture2.HideRandomWords(numberOfWords += 1);
            }
            // show words
            if(userKey == "LeftArrow")
            {
                if(numberOfWords > 1)
                {
                    numberOfWords -= 1;
                }
                scripture2.ShowPreviousWords(numberOfWords);
            }
        }

        // display hidden scripture
        Console.Clear();
        Console.WriteLine(scripture2.GetDisplayText());
    }
}