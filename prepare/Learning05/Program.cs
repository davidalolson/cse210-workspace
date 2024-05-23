using System;

class Program
{
    static void Main(string[] args)
    {
        // initiate with constructors
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("green", 6, 8);
        Circle circle = new Circle("blue", 1/Math.Sqrt(Math.PI));
        
        // initialize shape list with shapes
        List<Shape> shapes = new List<Shape>([square, rectangle, circle]);

        // loop to test all shapes
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetType());     // display shape
            Console.WriteLine(shape.GetColor());    // display color
            Console.WriteLine(shape.GetArea());     // display area
            Console.WriteLine();                    // separator
        }
    }
}