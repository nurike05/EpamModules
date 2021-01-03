using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForPractice
{
    /// <summary>
    /// Class with methods for calculating the area and perimeter of the square.
    /// </summary>
    class Square : Shape
    {
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Math.Round(Width * Width, 2);
        }
       
        public override double CalculatePerimeter()
        {
            return Math.Round(4 * Width, 2);
        }
    }
}
