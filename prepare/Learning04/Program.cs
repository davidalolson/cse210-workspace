using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("David Olson", "Multivariable Calculus");
        // Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("David Olson", "Multivariable Calculus", "Section 3.8", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}