using System;


class Program
{
    static void Main(string[] args)
    {
        Square shape01 = new Square("Red", 10);
        Rectangle shape02 = new Rectangle("Green", 10, 25);
        Circle shape03 = new Circle("Blue", 2.5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape01);
        shapes.Add(shape02);
        shapes.Add(shape03);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}