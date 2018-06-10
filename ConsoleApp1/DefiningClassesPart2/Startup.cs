using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        private int X;
        private int Y;
        private int Z;

        private static readonly Point3D O = new Point3D(0,0,0);

        public Point3D(int x,int y,int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }

        public static Point3D ReturnO()
        {
            return O;
        }
    }

    class Startup
    {
        static void Main(string[] args)
        {
            Point3D myPont = new Point3D(1,2,1);

            Console.WriteLine(myPont);
            Console.WriteLine(Point3D.ReturnO());

        }
    }
}
