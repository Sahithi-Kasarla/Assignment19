using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShapeAreaLib.Class1;

namespace Assignment19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape (1. Rectangle, 2. Square, 3. Circle, 4. Triangle):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter length and width for Rectangle:");
                    double length = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    double rectangleArea = Rectangle.Area(length, width);
                    Console.WriteLine($"Area of Rectangle: {rectangleArea}");
                    break;

                case 2:
                    Console.WriteLine("Enter side length for Square:");
                    double sideLength = Convert.ToDouble(Console.ReadLine());
                    double squareArea = Square.Area(sideLength);
                    Console.WriteLine($"Area of Square: {squareArea}");
                    break;

                case 3:
                    Console.WriteLine("Enter radius for Circle:");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double circleArea = Circle.Area(radius);
                    Console.WriteLine($"Area of Circle: {circleArea}");
                    break;

                case 4:
                    Console.WriteLine("Enter base and height for Triangle:");
                    double baseTriangle = Convert.ToDouble(Console.ReadLine());
                    double heightTriangle = Convert.ToDouble(Console.ReadLine());
                    double triangleArea = Triangle.Area(baseTriangle, heightTriangle);
                    Console.WriteLine($"Area of Triangle: {triangleArea}");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
