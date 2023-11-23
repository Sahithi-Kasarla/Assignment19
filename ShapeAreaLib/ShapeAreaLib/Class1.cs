using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Class1
    {
        public class Rectangle
        {
            public static double Area(double length, double width)
            {
                return length * width;
            }
        }
        public class Square
        {
            public static double Area(double side)
            {
                return side * side;
            }
        }
        public class Circle
        {
            public static double Area(double radius)
            {
                return Math.PI * radius * radius;
            }
        }
        public class Triangle
        {
            public static double Area(double baseLength, double height)
            {
                return 0.5 * baseLength * height;
            }
    }   }
}
