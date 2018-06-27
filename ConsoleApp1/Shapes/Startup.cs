using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Startup
    {
        static void Main(string[] args)
        {
            var triangleFirst = new Triangle(10,60);
            var triangleSecond = new Triangle(5,10);

            var rectangleFirst = new Rectangle(10,60);
            var rectangleSecond = new Rectangle(5,10);

            var squareFirst = new Square(20,20);
            var squareSecond = new Square(10,10);

            List<Shape> Shapes = new List<Shape>() {triangleFirst,triangleSecond,rectangleFirst,rectangleSecond,squareFirst,squareSecond};

            foreach (var shape in Shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
