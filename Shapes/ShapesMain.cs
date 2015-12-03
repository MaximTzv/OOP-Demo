using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shapes.Interfaces;
using Shapes.Shape;

namespace Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Rectangle(15, 10.8),
                new Rhombus(7, 2.9),
                new Circle(3.6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Figure:{0}{3} Area:{1:F2}{3} Perimeter:{2:F2}{3}",
                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter(), Environment.NewLine);
            }
        }
    }
}
