
using System;
using Shapes.Interfaces;

namespace Shapes.Shape
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public double CalculateArea()
        {
            double area = (Math.Pow(this.Radius, 2)) * Math.PI;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = (this.Radius * 2) * Math.PI;
            return perimeter;
        }
    }
}
