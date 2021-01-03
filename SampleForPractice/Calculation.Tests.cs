using SampleForPractice;

using NUnit.Framework;

namespace SampleForPractice
{
    [TestFixture]
    class Calculation
    {
        [TestCase(2, 2, 4)]
        [TestCase(5, 2, 10)]
        public void Calculate_Rectangle_Area(double a, double b, double result)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = a;
            rectangle.Width = b;
            Assert.AreEqual(rectangle.CalculateArea(), result);
        }

        [TestCase(2, 2, 8)]
        [TestCase(5, 2, 14)]
        public void Calculate_Rectangle_Perimeter(double a, double b, double result)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = a;
            rectangle.Width = b;
            Assert.AreEqual(rectangle.CalculatePerimeter(), result);
        }

        [TestCase(2, 4)]
        [TestCase(5, 25)]
        public void Calculate_Square_Area(double a, double result)
        {
            Square square = new Square();
            square.Width = a;
            Assert.AreEqual(square.CalculateArea(), result);
        }

        [TestCase(2, 8)]
        [TestCase(5, 20)]
        public void Calculate_Square_Perimeter(double a, double result)
        {
            Square square = new Square();
            square.Width = a;
            Assert.AreEqual(square.CalculatePerimeter(), result);
        }

        [TestCase(2, 2, 2)]
        [TestCase(5, 2, 5)]
        public void Calculate_Triangle_Area(double a, double b, double result)
        {
            Triangle triangle = new Triangle();
            triangle.Height = a;
            triangle.Width = b;
            Assert.AreEqual(triangle.CalculateArea(), result);
        }

        [TestCase(2, 2, 6.83)]
        [TestCase(5, 2, 12.39)]
        public void Calculate_Triangle_Perimeter(double a, double b, double result)
        {
            Triangle triangle = new Triangle();
            triangle.Height = a;
            triangle.Width = b;
            Assert.AreEqual(triangle.CalculatePerimeter(), result);
        }

        [TestCase(2, 12.57)]
        [TestCase(5, 78.54)]
        public void Calculate_Circle_Area(double a, double result)
        {
            Circle circle = new Circle();
            circle.Radius = a;
            Assert.AreEqual(circle.CalculateArea(), result);
        }

        [TestCase(2, 12.57)]
        [TestCase(5, 31.42)]
        public void Calculate_Circle_Perimeter(double a, double result)
        {
            Circle circle = new Circle();
            circle.Radius = a;
            Assert.AreEqual(circle.CalculatePerimeter(), result);
        }
    }
}
