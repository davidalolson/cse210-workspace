public class Resume
{
    // attributes
    public string _personName;
    public List<Job>  _jobsList;

    // meathods
    public Resume() //constructor for initialization
    {
        _jobsList = new List<Job>();
    }
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}\nJobs:");
        
        // use foreach loop to display all job entries
        foreach (Job job in _jobsList)
        {
            job.DisplayJobDetails();
        }
    }
}