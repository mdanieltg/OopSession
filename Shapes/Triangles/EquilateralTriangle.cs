namespace OopSession.Shapes.Triangles;

public class EquilateralTriangle : Shape
{
    private double _base;
    private double _height;

    public EquilateralTriangle(double @base, double height)
    {
        _base = @base;
        _height = height;
    }

    public override double GetArea() => _base * _height / 2;
    public override double GetPerimeter() => 3 * _base;
}
