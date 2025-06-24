using System;
using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radio;

    public Circle(string color, double radio) : base(color)
    {
        _radio = radio;
    }

    public double GetRadio()
    {
        return _radio;
    }

    public void SetRadio(double radio)
    {
        _radio = radio;
    }


    public override double GetArea()
    {

        return _radio * _radio * Math.PI;
    }


}