using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trapeze : Triangle
    {
        private double D;

        public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
        {
            if (a <= 0 || b <= 0 || c <= 0 || h <= 0 || d <= 0)
            {
                throw new ArgumentException("Values must be greater than zero.");
            }

            D = d;
        }

        public override double GetArea() => ((B + D) * H) / 2;

        public override double GetPerimeter() => A + B + C + D;
    }
}



