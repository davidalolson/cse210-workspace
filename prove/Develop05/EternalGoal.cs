/// <summary>
/// This class inherits from the Goal class. These are goals that are never completed, but the user
/// is rewarded every time the goal associated event is recorded.
/// </summary>
public class EternalGoal : Goal
{
    // constructor
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
                                                        // no additional attributes
    }
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