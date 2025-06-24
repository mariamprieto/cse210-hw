using System;

public class Shape()
{
    string _color = "";

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;

    }

    public virtual float GetArea()
    {
        return 1;
    }
}