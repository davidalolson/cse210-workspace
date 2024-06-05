/*
Sub class of Activity. Overrides methods to reflect running activities.
*/
public class Running : Activity
{
    // attributes
    private double _distance;

    // constructor - derived from base
    public Running(string date, double duration, double distance) : base(date, duration)
    // initialize values
    {
        _distance = distance;
    }

    // methods - override from base for running specific methods
    public override double Distance()
    // return distance
    {
        return _distance;
    }
    public override double Speed()
    {
        return base.Speed();
    }
    public override double Pace()
    {
        return base.Pace();
    }

}