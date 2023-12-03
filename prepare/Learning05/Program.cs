using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new("Blue", 5);

        Circle circle = new("Pink", 4);

        Rectangle rectangle = new("Green", 5, 4);

        List<Shape> shapes = new();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"This a {shape.GetColor()} {shape}.\nThe area of the {shape} is {shape.GetArea()}\n");
        }

    }
}