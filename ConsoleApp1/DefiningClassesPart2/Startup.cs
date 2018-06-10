using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        private static int X;
        private static int Y;
        private static int Z;

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
    }

    class Startup
    {
        static void Main(string[] args)
        {
            Point3D myPoint3D = new Point3D(1,2,3);
        }
    }
}
