using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction0 = new Fraction();
        Fraction fraction1 = new Fraction(6, 7);
        Fraction fraction2 = new Fraction(1, 2);
        Fraction fraction3 = new Fraction(6);


        Console.WriteLine(fraction0.GetDecimalValue());
        Console.WriteLine(fraction0.GetFractionString());

        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());

        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());

        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
    }
}