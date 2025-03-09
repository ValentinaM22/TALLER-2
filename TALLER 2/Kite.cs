using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Kite : Rhombus
    {
        public double B { get; }

        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            if (a <= 0 || d1 <= 0 || d2 <= 0 || b <= 0)
            {
                throw new ArgumentException("Values must be greater than zero.");
            }

            B = b;
        }

        public override double GetArea() => ((D1 * D2) / 2);
        public override double GetPerimeter() => 2 * (A + B);
    }
}
