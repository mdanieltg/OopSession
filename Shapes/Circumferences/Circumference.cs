namespace OopSession.Shapes.Circumferences;

public abstract class Circumference : Shape
{
    protected double _radius;

    protected Circumference(double radius) => _radius = radius;

    public double GetRadius() => _radius;
    public double GetDiameter() => 2 * _radius;
}
