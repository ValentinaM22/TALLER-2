using System;
using System.Collections.Generic;

namespace Geometry
{
    abstract class GeometricFigure
    {
        public string Name { get; }

        protected GeometricFigure(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString() => $"{Name} => Área: {GetArea():F2} Perímetro: {GetPerimeter():F2}";
    }
}

    

    

   