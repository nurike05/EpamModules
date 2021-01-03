using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForPractice
{
    /// <summary>
    /// Class with methods for calculating the area and perimeter of the rectangle.
    /// </summary>
    class Rectangle : Square
    {
        public double Length { get; set; }
        public new double CalculateArea()
		{
			return Math.Round(Width * Length, 2);
		}

		public new double CalculatePerimeter()
        {
			return Math.Round(2 * Width + 2 * Length, 2);
        }
	}
}
