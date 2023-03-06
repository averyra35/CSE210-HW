using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq = new Square("Blue", 8);
        shapes.Add(sq);

        Rectangle r = new Rectangle("Green", 4, 6);
        shapes.Add(r);

        Circle c = new Circle("Violet", 10);
        shapes.Add(c);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}