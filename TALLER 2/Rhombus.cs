using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry

{
    public class Rhombus : Square
    {
        public double D1 { get; }
        public double D2 { get; }

        public Rhombus(string name, double a, double d1, double d2)
            : base(name, a)
        {
            if (a <= 0 || d1 <= 0 || d2 <= 0)
            {
                throw new ArgumentException("Values must be greater than zero.");
            }

            D1 = d1;
            D2 = d2;
        }

        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 4 * A;
    }
}
