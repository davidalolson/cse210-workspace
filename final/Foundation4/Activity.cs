/*
Base class of activities. Contains attributes and methods shared among
sub activity classes.
*/
using System.Runtime.InteropServices.Marshalling;

public abstract class Activity
{
    // attributes - track important details
    private string _date;
    private double _duration;

    // constructor - base
    public Activity(string date, double duration)
    // initialize values
    {
        _date = date;
        _duration = duration;
    }

    // methods to be overridden by derived classes
    public virtual double Distance()
    // calculates distance depending on conditions from sub class
    {
        return (Speed() * _duration) / 60;
    }
    public virtual double Speed()
    // calculates speed depending on conditions from sub class
    {
        return (Distance() / _duration) * 60;
    }
    public virtual double Pace()
    // calculates pace depending on conditions from sub class
    {
        return _duration / Distance();
    }

    // method not to be overridden
    public void GetSummary()
    // return summary about specified activity utilizing polymorphism
    {
        Console.WriteLine($"{_date} {GetType()} ({_duration} min): Distance {Distance():F1} miles, Speed {Speed():F1} mph, Pace: {Pace():F1} min per mile");
    }
}