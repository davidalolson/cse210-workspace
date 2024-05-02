using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BIOTRONIC";
        Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "MSEI";
        Console.WriteLine(job2._company);
    }
}