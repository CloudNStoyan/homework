using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        public Square(double height, double widht) : base(widht, height)
        {
            if (height != widht)
            {
                throw new ArgumentException("Height and Width must be equal!");
            }
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
