public class Rectangle : Shape
{
    private double _npLength;
    private double _npWidth;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _npLength = length;
        _npWidth = width;
    }

    public override double GetArea()
    {
        double area = _npLength * _npWidth;
        return area;
    }
}