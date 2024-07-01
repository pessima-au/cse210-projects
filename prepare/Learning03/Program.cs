using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());
        
        Fraction fraction2 = new Fraction(3);
         Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());

        Fraction fraction3 = new Fraction(4, 6);
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());

        Fraction fraction4 = new Fraction(7, 9);
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());

        

    }
}