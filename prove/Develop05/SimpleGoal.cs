/// <summary>
/// This class inherits from the Goal class. These are goals that can be completed and the user will
/// be awarded points.
/// </summary>
public class SimpleGoal : Goal
{
    // attributes
    private bool _isComplete;                           // test if goal has been completed

    // constructor
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
                                                        // no additional attributes
    }

    // methods
    public override void RecordEvent()                  // (?)
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()                   // (?)
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()    // (?)
    {
        throw new NotImplementedException();
    }


}