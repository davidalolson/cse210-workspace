public class MathAssignment : Assignment
{
    // attributes
    private string _textbookSection;
    private string _problems;
    // constructor with inherited traits
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    // methods
    public string GetHomeworkList()
    {
        
        return $"Section {_textbookSection} Problems {_problems}";
    }
}