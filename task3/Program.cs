using task3;

public static class Program
{
    public static void Main()
    {
        Circle circle = new Circle(6);
        Console.WriteLine(circle.FindArea());
        Triangle triangle = new Triangle(5, 4);
        Console.WriteLine(triangle.FindArea());
        Square square = new Square(7);
        Console.WriteLine(square.FindArea());
    }
}