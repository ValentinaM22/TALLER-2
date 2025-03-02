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

    class Square : GeometricFigure
    {
        public double A { get; }
        public Square(string name, double a) : base(name) { A = a; }
        public override double GetArea() => A * A;
        public override double GetPerimeter() => 4 * A;
    }

    class Circle : GeometricFigure
    {
        public double R { get; }
        public Circle(string name, double r) : base(name) { R = r; }
        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => 2 * Math.PI * R;
    }

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

    class Kite : Rhombus
    {
        public double B { get; }
        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            B = b;
        }
        public override double GetPerimeter() => 2 * (A + B);
    }

    class Rectangle : GeometricFigure
    {
        public double A { get; }
        public double B { get; }
        public Rectangle(string name, double a, double b) : base(name)
        {
            A = a;
            B = b;
        }
        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }

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

    class Triangle : GeometricFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Height { get; }

        public Triangle(string name, double a, double b, double c, double height) : base(name)
        {
            A = a;
            B = b;
            C = c;
            Height = height;
        }
        public override double GetArea() => (A * Height) / 2;
        public override double GetPerimeter() => A + B + C;
    }

    class Trapeze : GeometricFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double D { get; }
        public double Height { get; }

        public Trapeze(string name, double a, double b, double c, double d, double height) : base(name)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            Height = height;
        }
        public override double GetArea() => ((A + B) * Height) / 2;
        public override double GetPerimeter() => A + B + C + D;
    }
}
