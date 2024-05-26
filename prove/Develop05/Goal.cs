/// <summary>
/// This class is the parent class. It cannot be called independently. It is the
/// framework for the child classes.
/// </summary>
public abstract class Goal
{
    // attributes
    private string _shortName;                          // get goal name from user input
    private string _description;                        // use with _shortName in format (and)
    private int _points;                             // track user score
    
    // constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;                              // set attributes
        _description = description;
        _points = points;
    }
    
    // methods
    public virtual void RecordEvent()                   // increment score according to behavior of goal type
    {

    }
    public virtual bool IsComplete()                    // return bool according to behavior of goal type
    {
        return false;
    }                  
    public virtual string GetStringRepresentation()     // return attributes for IO
    {
        return $"{_shortName},{_description},{_points}";
    }
    public virtual string GetDetailsString()            // this is only modified in the ChecklistGoal class
    {
        return $"{IsComplete().ToString()} {_shortName} ({_description})".Replace("False", "[ ]").Replace("True","[X]");
    }

}