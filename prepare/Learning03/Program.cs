using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // 1/1
        Fraction fraction1 = new Fraction();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        // 5/1
        Fraction fraction2 = new Fraction(5);

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        // 3/4
        Fraction fraction3 = new Fraction(3,4);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // 1/3
        fraction1.SetBottom(3);
        
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
    }
}