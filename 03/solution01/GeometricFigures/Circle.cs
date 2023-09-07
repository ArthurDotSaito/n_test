using System;

namespace GeometricFigures
{
    public class Circle : GeometricFigure
    {
        private double _radius;

        public Circle(double radius) => _radius = radius;
        public override string Type => "Circle";
        public override double CalculateArea() => Math.PI * Math.Pow(_radius, 2);
    }
}