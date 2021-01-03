using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForPractice
{
    /// <summary>
    /// Class with methods for calculating the area and perimeter of the circle.
    /// </summary>
    class Circle : Shape
    {
        public double Radius { get; set; }
        
        public override double CalculateArea()
		{
			return Math.Round(Radius * Radius * Math.PI, 2);
		}

        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
        }
    }
}
