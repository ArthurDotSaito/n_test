using System;

namespace GeometricFigures
{
    public class Triangle : GeometricFigure
    {
        private double _side;

        public Triangle(double side) => _side = side;
        public override string Type => "Triangle";
        public override double CalculateArea() => (Math.Sqrt(3) / 4) * Math.Pow(_side, 2);
    }
}