using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        private static Point3D[] PathPoints3D;
        public Path(params Point3D[] points)
        {
            PathPoints3D = points;
        }

        public Point3D Get(int index)
        {
            return PathPoints3D[index];
        }

        public override string ToString()
        {
            return ConvertToString(PathPoints3D);
        }

        private string ConvertToString(Point3D[] points)
        {
            var build = new StringBuilder();
            for (int i = 0; i < points.Length; i++)
            {
                build.AppendLine(points[i].ToString());
            }

            return build.ToString().Trim();
        }
    }

    public static class PathStorage
    {
        public static string DicPath = @"C:\Users\Stoyan\Documents\temp\";
        public static void Save(Path path)
        {
            if (!File.Exists($"{DicPath}Path-{Date()}.txt"))
            {
                File.WriteAllText($"{DicPath}Path-{Date()}.txt",path.ToString());
                Console.WriteLine("Saved!");
            }
            else
            {
                Console.WriteLine("File already exist!");
            }
        }

        public static Path Load(string name)
        {
            if (File.Exists($"{DicPath}{name}.txt"))
            {
                var points = File.ReadAllLines($"{DicPath}{name}.txt");

                var Points3D = new Point3D[points.Length];

                for (int i = 0; i < Points3D.Length; i++)
                {
                    int x = int.Parse(points[i].Split(',')[0]);
                    int y = int.Parse(points[i].Split(',')[1]);
                    int z = int.Parse(points[i].Split(',')[2]);
                    Points3D[i] = new Point3D(x,y,z);
                }

                return new Path(Points3D);
            }
            else
            {
                Console.WriteLine($"There is no Path with the name {name} in {DicPath}!");
                return new Path(new Point3D(0,0,0));
            }
        }

        public static string Date()
        {
            return $"{DateTime.Now.Month.ToString().PadLeft(2, '0')}-{DateTime.Now.Day.ToString().PadLeft(2, '0')}-{DateTime.Now.Hour.ToString().PadLeft(2, '0')}-{DateTime.Now.Minute.ToString().PadLeft(2,'0')}-{DateTime.Now.Second.ToString().PadLeft(2, '0')}";
        }
    }
    [Version(2,11)]
    class Startup
    {
        static void Main(string[] args)
        {

            var arr = typeof(Startup).GetCustomAttributes();
            foreach (var o in arr)
            {
                var attribute = (Version) o;
                Console.WriteLine(attribute.GetVersion);
            }

        }
    }
}
