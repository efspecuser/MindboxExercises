using System;
using ShapeAreaCalc.Contracts;

namespace ShapeAreaCalc
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be a non-null value");

            this.Radius = radius;
        }

        public double Radius { get; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
