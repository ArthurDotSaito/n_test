using System;
using GeometricFigures;
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, GeometricFigure> figureDictionary = new Dictionary<string, GeometricFigure>();

            figureDictionary["Square"] = new Square(3);
            figureDictionary["Triangle"] = new Triangle(3);
            figureDictionary["Circle"] = new Circle(3);

            foreach (var keyValue in figureDictionary)
            {
                Console.WriteLine("Type: " + keyValue.Value.Type);
                Console.WriteLine("Área " + keyValue.Value.CalculateArea());
            }

        }
    }
}
