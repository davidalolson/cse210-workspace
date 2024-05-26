/// <summary>
/// This class inherits from the Goal class. These are goals that are never completed, but the user
/// is rewarded every time the goal associated event is recorded.
/// </summary>
public class EternalGoal : Goal
{
    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
                                                        // no additional attributes
    }
    public override void RecordEvent()                
    {
        // nothing to record here...
    }
    public override bool IsComplete()                  
    {
        return base.IsComplete();
    }
    public override string GetStringRepresentation()    
    {
        return base.GetStringRepresentation();
    }

}