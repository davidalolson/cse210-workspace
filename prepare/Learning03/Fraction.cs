using System.Dynamic;

public class Fraction
{
    // attributes
    private int _top;
    private int _bottom;
    public Fraction()
    {
        // default 1/1
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        // ?/1
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        // ?/?
        _top = top;
        _bottom = bottom;
    }
    // getters and setters
    public int GetTop() 
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    // methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom; // use double to match return type
    }



}