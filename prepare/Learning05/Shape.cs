public abstract class Shape
{
    private string _npColor;

    public Shape(string color)
    {
        _npColor = color;
    }
    
    public string npGetColor()
    {
        return _npColor;
    }

    public void npSetColor(string color)
    {
        _npColor = color;
    }

    public abstract double GetArea();
}