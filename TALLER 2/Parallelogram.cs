using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry

{
    class Parallelogram : GeometricFigure
    {
        public double Base { get; }
        public double Height { get; }
        public double Side { get; }

        public Parallelogram(string name, double baseLength, double height, double side) : base(name)
        {
            Base = baseLength;
            Height = height;
            Side = side;
        }

        public override double GetArea() => Base * Height;
        public override double GetPerimeter() => 2 * (Base + Side);
    }
}
