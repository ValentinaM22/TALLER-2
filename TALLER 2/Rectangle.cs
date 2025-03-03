using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Rectangle : GeometricFigure
    {
        public double A { get; }
        public double B { get; }
        public Rectangle(string name, double a, double b) : base(name)
        {
            A = a;
            B = b;
        }
        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
