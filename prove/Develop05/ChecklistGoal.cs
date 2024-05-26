/// <summary>
/// This inherits from the Goal class. These are goals which must be completed multiple times for the
/// user to receive a bonus score reward.
/// </summary>
public class ChecklistGoal : Goal
{
    // attributes
    private int _amountCompleted = 0;    // numerator
    private int _target;                // denominator
    private int _bonus;                 // score bonus for obtaining target

    // constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;               // set additional attributes target and bonus
        _bonus = bonus;
    }

    // methods
    public override void RecordEvent()                 
    {
        _amountCompleted += 1;
    }
    public override bool IsComplete()                   
    {
        if(_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }
    public override string GetDetailsString()           // details string with fraction
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()    
    {
        return $"{base.GetStringRepresentation()},{_target},{_bonus},{_amountCompleted}";
    }

}