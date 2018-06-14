using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class IEnumerableExtension
    {
        public static T TheSum<T>(this IEnumerable<T> elements)  
        {

            dynamic sum = 0;

            foreach (T element in elements)
            {
                dynamic a = element;
                sum += a;
            }

            return sum;
        }

        public static T TheMin<T>(this IEnumerable<T> elements)
        {
            dynamic best = Int32.MaxValue;

            foreach (var element in elements)
            {
                dynamic holder = element;
                if (holder < best)
                {
                    best = holder;
                }
            }

            return best;
        }

        public static T TheMax<T>(this IEnumerable<T> elements)
        {
            dynamic best = 0;

            foreach (var element in elements)
            {
                dynamic holder = element;

                if (holder > best)
                {
                    best = holder;
                }
            }

            return best;
        }

        public static T TheAverage<T>(this IEnumerable<T> elements)
        {
            dynamic sum = elements.TheSum();

            return sum / elements.Count();
        }

        //Find Whats Group Product

        public static IEnumerable<T> Product<T>(this IEnumerable<T> firstElements,IEnumerable<T> secondElements)
        {

            var fElements = new List<dynamic>();
            var sElements = new List<dynamic>();


            if (firstElements.Count() != secondElements.Count())
            {
                throw new Exception("Collections must have same length!");
            }

            foreach (var firstElement in firstElements)
            {
                fElements.Add(firstElement);
            }

            foreach (var sElement in secondElements)
            {
                sElements.Add(sElement);
            }


            T[] result = new T[fElements.Count];

            for (int i = 0; i < fElements.Count; i++)
            {
                result[i] = fElements[i] * sElements[i];
            }

            IEnumerable<T> resultEnumerable = from value in result select value;

            return resultEnumerable;
        }


    }
}
