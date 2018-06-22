using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public static class Extension
    {
        public static double AverageAge(this Animal[] animals)
        {
            double average = 0;

            average = animals.Select(a => a.Age).ToArray().Average();

            return average;
        }
    }
}
