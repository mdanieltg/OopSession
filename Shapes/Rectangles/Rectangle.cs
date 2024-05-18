namespace OopSession.Shapes.Rectangles;

public class Rectangle : Shape
{
    private double _longSide;
    private double _shortSide;

    public Rectangle(double shortSide, double longSide)
    {
        _shortSide = shortSide;
        _longSide = longSide;
    }

    public override double GetArea() => _shortSide * _longSide;
    public override double GetPerimeter() => 2 * _shortSide + 2 * _longSide;
}
