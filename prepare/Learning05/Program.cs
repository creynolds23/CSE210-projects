using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Red", 3);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Gold", 6, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Teal", 20);
        shapes.Add(shape3);
        Console.WriteLine();
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        Console.WriteLine();
    }
}