public class Shape
{
    // attributes
    private string _color;
    // coonstructor
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    /// <param name="color"></param>
    public void SetColor(string color) {
        _color = color;
    }
    // use as base for area calculations
    public virtual double GetArea()
    {
        return 0;
    }
}