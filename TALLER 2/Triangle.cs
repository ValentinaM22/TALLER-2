using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle : GeometricFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Height { get; }

        public Triangle(string name, double a, double b, double c, double height) : base(name)
        {
            A = a;
            B = b;
            C = c;
            Height = height;
        }
        public override double GetArea() => (A * Height) / 2;
        public override double GetPerimeter() => A + B + C;
    }
}
