using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Trapeze : GeometricFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double D { get; }
        public double Height { get; }

        public Trapeze(string name, double a, double b, double c, double d, double height) : base(name)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            Height = height;
        }
        public override double GetArea() => ((A + B) * Height) / 2;
        public override double GetPerimeter() => A + B + C + D;
    }
}


