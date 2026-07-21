using System.Formats.Asn1;

public class Square : Shape
{
    private double _npSide;

    public Square(string color, double side) : base(color)
    {
        _npSide = side;
    }

    public override double GetArea()
    {
        double area = _npSide * _npSide;
        return area;
    }
}