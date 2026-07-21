using System;
using System.Drawing;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 4);
        shapes.Add(square);

        Circle circle = new Circle("red", 5);
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle("green", 6, 5);
        shapes.Add(rectangle);

        foreach (Shape s in shapes)
        {
            string color = s.npGetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}