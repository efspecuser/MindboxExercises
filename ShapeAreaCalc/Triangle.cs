using System;
using ShapeAreaCalc.Contracts;

namespace ShapeAreaCalc
{
    public class Triangle : IShape
    {
        // public members
        public Triangle(double side1, double side2, double side3)
        {
            if(side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Triangle sides should all have non-null lengths");

            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        

        public double CalculateArea()
        {
            if (this._area.HasValue)
                return this._area.Value;

            var halfPerimeter = (this.Side1 + this.Side2 + this.Side3) / 2;
            this._area = Math.Pow(halfPerimeter * (halfPerimeter - this.Side1) * (halfPerimeter - this.Side2) * (halfPerimeter - this.Side3)
                , 2);
            return this._area.Value;
        }

        //
        public bool IsRight => 
            CheckForHypotenuseAndLegs(this.Side1, this.Side2, this.Side3)
            ||
            CheckForHypotenuseAndLegs(this.Side1, this.Side3, this.Side2)
            ||
            CheckForHypotenuseAndLegs(this.Side2, this.Side3, this.Side1)
        ;

        // private members
        private double? _area;

        private static double _accuracy = 0.0000001;

        private static bool CheckForHypotenuseAndLegs(double leg1, double leg2, double hypotenuse)
        {
            return Math.Abs(leg1 * leg1 + leg2 * leg2 - hypotenuse * hypotenuse) / hypotenuse * hypotenuse
                   < _accuracy;
        }
    }
}