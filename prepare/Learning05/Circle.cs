public class Circle : Shape
{
    private double _npRadius;

    public Circle(string color, double radius) : base(color)
    {
        _npRadius = radius;
    }

    public override double GetArea()
    {
        double area = _npRadius * Math.PI;
        return area;
    }
}