using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Rectangle
    {
        public double C { get; }
        public double H { get; }

        public Triangle(string name, double A, double B, double c, double h) : base(name, A, B)
        {
            if (A <= 0 || B <= 0 || c <= 0 || h <= 0)
            {
                throw new ArgumentException("Values must be greater than zero.");
            }

            C = c;
            H = h;
        }

        public override double GetArea() => ((B * H) / 2);

        public override double GetPerimeter() => A + B + C;
    }
}
