public class Comment
{
    // attributes to store commentator name and comment text
    private string _name;
    private string _text;

    // constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void DisplayComment()                        // print comment details
    {
        Console.WriteLine($"@{_name}: {_text}");
    }
}