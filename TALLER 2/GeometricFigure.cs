using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Geometry
{
    public abstract class GeometricFigure
    {
        public string Name { get; }

        protected GeometricFigure(string name) => Name = name;

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString() => $"{Name} => Area: {GetArea():F5}, Perimeter: {GetPerimeter():F5}";
    }
}









