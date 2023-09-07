using System;

namespace GeometricFigures
{
    public class Square : GeometricFigure
    {
        private double _side;

        public Square(double side) => _side = side;
        public override string Type => "Square";
        public override double CalculateArea() => _side * _side;

    }
}