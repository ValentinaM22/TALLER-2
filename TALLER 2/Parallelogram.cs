using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry

{
    public class Parallelogram : Rectangle
    {
        private double H;

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea() => B * H;
        public override double GetPerimeter() => 2 * (A + B);

    }
}

