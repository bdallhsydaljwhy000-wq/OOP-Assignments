//OOP4
class Shape
{
    public virtual double CalculateArea()
    { 
    return 0;
    }
}

class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;

    }
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes= new List<Shape>();

        shapes.Add(new Circle(7));
        shapes.Add(new Rectangle(5,6));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetType().Name);
            Console.WriteLine($"Area = {shape.CalculateArea()}");
        }

    }
}    
