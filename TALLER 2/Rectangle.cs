using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle : Square
    {
        public double B { get; }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Values must be greater than zero.");
            }

            B = b;
        }

        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }
}