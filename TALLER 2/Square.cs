using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry

{
    class Square : GeometricFigure
    {
        public double A { get; }
        public Square(string name, double a) : base(name) { A = a; }
        public override double GetArea() => A * A;
        public override double GetPerimeter() => 4 * A;
    }
}
