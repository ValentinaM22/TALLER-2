using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Kite : Rhombus
    {
        public double B { get; }
        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            B = b;
        }
        public override double GetPerimeter() => 2 * (A + B);
    }
}
