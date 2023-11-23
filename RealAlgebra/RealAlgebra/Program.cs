using System;
using System.Drawing;
using ShapeAreaLib;
using Rectangle = ShapeAreaLib.Rectangle;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a shape to calculate the area:");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Square");
        Console.WriteLine("3. Circle");
        Console.WriteLine("4. Triangle");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter length of rectangle: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter width of rectangle: ");
                double width = double.Parse(Console.ReadLine());
                double rectangleArea = Rectangle.Area(length, width);
                Console.WriteLine($"Area of Rectangle: {rectangleArea}");
                break;

            case 2:
                Console.Write("Enter side of square: ");
                double side = double.Parse(Console.ReadLine());
                double squareArea = Square.Area(side);
                Console.WriteLine($"Area of Square: {squareArea}");
                break;

            case 3:
                Console.Write("Enter radius of circle: ");
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Circle.Area(radius);
                Console.WriteLine($"Area of Circle: {circleArea}");
                break;

            case 4:
                Console.Write("Enter base length of triangle: ");
                double baseLength = double.Parse(Console.ReadLine());
                Console.Write("Enter height of triangle: ");
                double height = double.Parse(Console.ReadLine());
                double triangleArea = Triangle.Area(baseLength, height);
                Console.WriteLine($"Area of Triangle: {triangleArea}");
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
