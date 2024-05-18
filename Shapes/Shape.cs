namespace OopSession.Shapes;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void PrintMessage()
    {
        Console.WriteLine("The area of the shape is {0:N2}, and the perimeter is {1:N2}",
            GetArea(), GetPerimeter());
    }
}
