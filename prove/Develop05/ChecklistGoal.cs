/// <summary>
/// This inherits from the Goal class. These are goals which must be completed multiple times for the
/// user to receive a bonus score reward.
/// </summary>
public class ChecklistGoal : Goal
{
    // attributes
    private int _amountCompleted;       // numerator
    private int _target;                // denominator
    private int _bonus;                 // score bonus for obtaining target

    // constructor
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;               // set additional attributes target and bonus
        _bonus = bonus;
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
    public override string GetDetailsString()           // details string with fraction
    {
        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()    // (?)
    {
        throw new NotImplementedException();
    }

}