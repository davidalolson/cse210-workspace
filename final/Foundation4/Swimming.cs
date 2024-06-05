/*
Sub class of Activity. Overrides methods to reflect swimming activities.
*/
public class Swimming : Activity
{
    // attributes - variable
    private int _laps;

    // attributes - constant
    private const double POOL_LENGTH = 164.042;     // imperial (ft)

    // constructor - derived from base
    public Swimming(string date, double duration, int laps) : base(date, duration)
    // initialize values
    {
        _laps = laps;
    }

    // methods - override from base for swimming specific methods
    public override double Distance()
    // calculate distance with swimming specific information
    {
        return _laps * (POOL_LENGTH * 0.3048) / 1000 * 0.62;
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