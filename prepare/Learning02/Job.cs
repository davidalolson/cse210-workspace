public class Job
{
    // attributes
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // meathods
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}