using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Shape
* *********************************************************************/

namespace InterfaceShape
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }
    /// <summary>
    /// To calculate area and perimeter of circle
    /// </summary>
    class Circle : IShape
    {
        int radius;

        public void ReadRadius()
        {
            Console.Write("Enter radius of Circle: ");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateArea()
        {
            return 22 * radius * radius / 7;
        }

        public int CalculatePerimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }
    /// <summary>
    /// To calculate area and perimeter of square
    /// </summary>
    class Square : IShape
    {
        int side;

        public void ReadSide()
        {
            Console.Write("Enter side of Square: ");
            side = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateArea()
        {
            return side * side;
        }

        public int CalculatePerimeter()
        {
            return 4 * side;
        }
    }
    /// <summary>
    /// To calculate area and perimeter of Rectangle
    /// </summary>
    class Rectangle : IShape
    {
        int length, breadth;

        public void ReadLengthBreadth()
        {
            Console.Write("Enter length of Rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Rectangle: ");
            breadth = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateArea()
        {
            return length * breadth;
        }

        public int CalculatePerimeter()
        {
            return 2 * (length + breadth);
        }
    }
    /// <summary>
    /// To calculate area and perimeter of Triangle
    /// </summary>
    class Triangle : IShape
    {
        int side, side1, side2, side3;

        public void ReadSides()
        {
            Console.Write("Enter side1 of Triangle: ");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side2 of Triangle: ");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side3 of Triangle: ");
            side3 = Convert.ToInt32(Console.ReadLine());

            side = (side1 + side2 + side3) / 2;
        }

        public int CalculateArea()
        {
            return (int)Math.Sqrt(side * (side - side1) * (side - side2) * (side - side3));
        }

        public int CalculatePerimeter()
        {
            return 2 * side;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.ReadRadius();
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(c.CalculatePerimeter());

            Square s = new Square();
            s.ReadSide();
            Console.WriteLine(s.CalculateArea());
            Console.WriteLine(s.CalculatePerimeter());

            Rectangle r = new Rectangle();
            r.ReadLengthBreadth();
            Console.WriteLine(r.CalculateArea());
            Console.WriteLine(r.CalculatePerimeter());

            Triangle t = new Triangle();
            t.ReadSides();
            Console.WriteLine(t.CalculateArea());
            Console.WriteLine(t.CalculatePerimeter());

            Console.ReadLine();
        }
    }
}
