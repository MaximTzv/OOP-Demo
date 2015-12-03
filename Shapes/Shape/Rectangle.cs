
using System;

namespace Shapes.Shape
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (2 * this.Height) + (2 * this.Width);
            return perimeter;
        }
    }
}
