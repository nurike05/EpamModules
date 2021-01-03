using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 20;
            rectangle.Length = 30;
            Square square = rectangle;
            Circle circle = new Circle();
            circle.Radius = 5;
            Triangle triangle = new Triangle();
            triangle.Width = 2;
            triangle.Height = 5;
            Console.WriteLine("Square Area is " + square.CalculateArea());
            Console.WriteLine("Square Perimeter is " + square.CalculatePerimeter());
            Console.WriteLine("Rectangle Area is " + rectangle.CalculateArea());
            Console.WriteLine("Rectangle Perimeter is " + rectangle.CalculatePerimeter());
            Console.WriteLine("Circle Area is " + circle.CalculateArea());
            Console.WriteLine("Circle Perimeter is " + circle.CalculatePerimeter());
            Console.WriteLine("Triangle Area is " + triangle.CalculateArea());
            Console.WriteLine("Triangle Perimeter is " + triangle.CalculatePerimeter());

            Console.ReadLine();
        }
    }
}
