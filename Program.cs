using OopSession.Shapes;
using OopSession.Shapes.Circumferences;
using OopSession.Shapes.Rectangles;

Circle circle = new Circle(2.5);
Rectangle rectangle = new Rectangle(2, 7);
Square square = new Square(8);
// Shape shape = new Shape(); // Cannot instantiate abstract classes.

circle.PrintMessage();
rectangle.PrintMessage();
square.PrintMessage();
