/// <summary>
/// This class inherits from the Goal class. These are goals that can be completed and the user will
/// be awarded points.
/// </summary>
public class SimpleGoal : Goal
{
    // attributes
    private bool _isComplete = false;                           // test if goal has been completed

    // constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
                                                        // no additional attributes
    }

    // methods
    public override void RecordEvent()                  // (?)
    {
        _isComplete = true;
    }
    public override bool IsComplete()                   // (?)
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()    // (?)
    {
        return $"{base.GetStringRepresentation()},{IsComplete()}";
    }


}