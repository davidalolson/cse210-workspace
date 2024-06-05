/*
Sub class of Activity. Overrides methods to reflect bicycling activities.
*/
public class Bicycling : Activity
{
    // attributes
    private double _speed;

    // constructor - derived from base
    public Bicycling(string date, double duration, double speed) : base(date, duration)
    // initialize values
    {
        _speed = speed;
    }

    // methods - override from base for bicycling specific methods
    public override double Distance()
    {
        return base.Distance();
    }
    public override double Speed()
    // calculate speed with bicycling specific information
    {
        return _speed;
    }
    public override double Pace()
    // calculate pace with bicycling specific information
    {
        return 60 / _speed;
    }
}