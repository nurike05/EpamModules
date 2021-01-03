using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForPractice
{
    /// <summary>
    /// Class with methods for calculating the area and perimeter of the triangle.
    /// </summary>
    class Triangle : Square
    {
        public double Height { get; set; }
        public override double CalculateArea()
		{
			return Math.Round(Width * Height * 0.5, 2);
		}
        public override double CalculatePerimeter()
        {
			var hipothenusa = Math.Sqrt(Width * Width + Height * Height);
            return Math.Round(Height + Width + hipothenusa, 2);
        }
    }
}
