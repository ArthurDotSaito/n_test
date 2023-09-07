using System;

namespace GeometricFigures
{
    public abstract class GeometricFigure
    {
        public abstract double CalculateArea();
        public abstract string Type { get; }
    }
}