using System; // get Random class
public class PromptGenerator
{
    public List<string> _promptList;            // attributes
    public PromptGenerator()                    // constructor
    {
        _promptList = new List<string>();
    }
    public string GetRandomPrompt()             // meathods
    {
        Random random = new Random();
        return _promptList[random.Next(0,9)];
    }

}