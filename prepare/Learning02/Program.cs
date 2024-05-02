using System;

class Program
{
    static void Main(string[] args)
    {
        // set up first job
        Job job1 = new Job();
        job1._company = "Sega";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1982;
        job1._endYear = 1985;

        // set up second job
        Job job2 = new Job();
        job2._company = "Nintendo";
        job2._jobTitle = "Manager";
        job2._startYear = 1986;
        job2._endYear = 1995;

        // set up resume by appending Job classes to it
        Resume resume1 = new Resume();
        resume1._personName = "Howard Lincoln";
        resume1._jobsList.Add(job1);
        resume1._jobsList.Add(job2);

        // display results
        resume1.DisplayResume();
    }
}