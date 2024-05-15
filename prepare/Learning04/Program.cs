using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("David Olson", "Multivariable Calculus");
        Console.WriteLine(assignment.GetSummary());
    }
}