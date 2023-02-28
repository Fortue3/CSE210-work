
using System;

class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square side1 = new Square("Red", 3);
        shapes.Add(side1);

        Rectangle side2 = new Rectangle("Blue", 4, 5);
        shapes.Add(side2);

        Circle side3 = new Circle("Green", 6);
        shapes.Add(side3);

        foreach (Shape side in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = side.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = side.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}