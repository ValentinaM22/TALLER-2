﻿using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : GeometricFigure
    {
        public double R { get; }

        public Circle(string name, double r) : base(name)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero.");
            }
            R = r;
        }

        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => 2 * Math.PI * R;
    }
}