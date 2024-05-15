using System;

class Program
{
    static void Main(string[] args)
    {
        // math assignment
        MathAssignment mathAssignment = new MathAssignment("David Olson", "Multivariable Calculus", "3.8", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine(); // newline char

        // writing assignment
        WritingAssignment writingAssignment = new WritingAssignment("Not David Olson", "Electric Circuits", "Fundamentals of Electricity");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}