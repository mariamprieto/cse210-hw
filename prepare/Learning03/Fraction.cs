using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public Fraction(int _wholeNumber)
    {
        _top = _wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {

        _top = top;
        _bottom = bottom;

    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {

        double results = (double) _top /  (double) _bottom;
        return  Math.Round(results,2);
    }
}