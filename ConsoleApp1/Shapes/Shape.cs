using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   public abstract class Shape
   {
       protected double Width { get; private set; }
       protected double Height { get; private set; }
       protected Shape(double width, double height)
       {
           this.Width = width;
           this.Height = height;
       }

       public virtual double CalculateSurface()
       {
           return Width * Height;
       }
   }
}
