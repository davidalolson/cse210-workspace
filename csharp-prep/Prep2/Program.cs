using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string rawGrade = Console.ReadLine();
        
        int grade = int.Parse(rawGrade);

        if (grade >= 90)
        {
            Console.WriteLine("You earned an A");
        }
        else if (grade < 90 && grade >= 80)
        {
            Console.WriteLine("You earned a B");
        }
        else if (grade < 80 && grade >=70)
        {
            Console.WriteLine("You earned a C");
        }
        else if (grade < 70 && grade >= 60)
        {
            Console.WriteLine("You earned(?) a D");
        }
        else
        {
            Console.WriteLine("You got an F");
        }
        if (grade < 70)
        {
            Console.WriteLine("Hrm, looks like you failed. Encouraging words.");
        }
        else
        {
            Console.WriteLine("A WINNER IS YOU");  // Pro Wrestling NES 1986
        }

    }
}