namespace OopSession.Shapes.Circumferences;

public class Circle : Circumference
{
    public Circle(double radius) : base(radius)
    {
    }

    public override double GetArea() => Math.PI * Math.Sqrt(_radius);
    public override double GetPerimeter() => 2 * Math.PI * _radius;
}
