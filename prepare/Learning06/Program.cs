using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue",4);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        
        Rectangle rectangle = new Rectangle("Green",6,3);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("Red", 5);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red",6));
        shapes.Add(new Rectangle("Pink",10,8));
        shapes.Add(new Circle("Yellow",6));

        foreach(Shape shape in shapes)
{       string Color = shape.GetColor();
        double Area = shape.GetArea();
        Console.WriteLine($"{Color}-{Area}");
}
    }
}