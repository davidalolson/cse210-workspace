/// <summary>
/// This class is the parent class. It cannot be called independently. It is the
/// framework for the child classes.
/// </summary>
public abstract class Goal
{
    // attributes
    private string _shortName;                          // get goal name from user input
    private string _description;                        // use with _shortName in format (and)
    private string _points;                             // track user score
    
    // constructor
    public Goal(string name, string description, string points)
    {
        _shortName = name;                              // set attributes
        _description = description;
        _points = points;
    }
    
    // methods
    public abstract void RecordEvent();                 // increment score according to behavior of goal type
    public abstract bool IsComplete();                  // return bool according to behavior of goal type
    public abstract string GetStringRepresentation();   // (?)
    public virtual string GetDetailsString()            // this is only modified in the ChecklistGoal class
    {
        return "";
    }

}