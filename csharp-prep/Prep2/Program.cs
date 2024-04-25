using System;

string letter; // set up letter variable (w/o init)
string sign = ""; //set up sign variable (init to "")

Console.Write("Please enter your grade percentage: ");
string rawGrade = Console.ReadLine();

int grade = int.Parse(rawGrade);

if (grade >= 90)
{
    letter = "A";
    if (grade > 100)
    {
        sign = "+"; // precaution for crazy high grades (lots of extra credit?)
    }
    else
    {
        if (grade - 90 >= 7)
        {
            sign = "+";
        }
        else if (grade - 90 < 3 && grade! >= 100)
        {
            sign = "-";
        }
    }
}
else if (grade < 90 && grade >= 80)
{
    letter = "B";
    if (grade - 80 >= 7)
    {
        sign = "+";
    }
    else if (grade - 80 < 3)
    {
        sign = "-";
    }
}
else if (grade < 80 && grade >= 70)
{
    letter = "C";
    if (grade - 70 >= 7)
    {
        sign = "+";
    }
    else if (grade - 70 < 3)
    {
        sign = "-";
    }
}
else if (grade < 70 && grade >= 60)
{
    letter = "D";
    if (grade - 60 >= 7)
    {
        sign = "+";
    }
    else if (grade - 60 < 3)
    {
        sign = "-";
    }
}
else
{
    letter = "F"; // Defaults to F

    //"...recognize that there is no F+ or F- grades, only F. 
    //Add additional logic to your program to detect these 
    //cases and handle them correctly."
    
    //Problem is there is no such thing as F+ or F- 
    //and no such system
    if (letter == "F")
    {
        letter = "F"; // logic handling case correctly
    }
}

Console.WriteLine($"You recieved: {letter}{sign}");

if (grade < 70)
{
    Console.WriteLine("Hrm, looks like you failed. Encouraging words.");
}
else
{
    Console.WriteLine("A WINNER IS YOU");  // Pro Wrestling NES 1986
}
