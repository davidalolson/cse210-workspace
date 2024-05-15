public class WritingAssignment : Assignment
{
    // attributes
    private string _title;
    // constructor with inherited traits
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    // methods
    public string GetWritingInformation()
    {
        return $"{_title} by {base.GetStudentName()}";
    }
}