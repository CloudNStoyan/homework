using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

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

    public static class CalculateDifference
    {
        public static int Point3D(Point3D firstPoint3D, Point3D secondPoint3D)
        {
            int pointX = Math.Abs(firstPoint3D.X - secondPoint3D.X);
            int pointY = Math.Abs(firstPoint3D.Y - secondPoint3D.Y);
            int pointZ = Math.Abs(firstPoint3D.Z - secondPoint3D.Z);


            return pointX + pointY + pointZ;
        }
    }

    public class Path
    {
        private Point3D[] Points3D;
        public Path(params Point3D[] points)
        {
            Points3D = points;
        }
    }

    class Startup
    {
        static void Main(string[] args)
        {
            Point3D myFirstPont = new Point3D(1,2,1);
            Point3D mySecondPoint = new Point3D(-1,-2,-1);
            Point3D myThirdPoint = new Point3D(0,1,0);

        }
    }
}
