using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry

{
    class Rhombus : Square
    {
        public double D1 { get; }
        public double D2 { get; }
        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }
        public override double GetArea() => (D1 * D2) / 2;
    }
}
