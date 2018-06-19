using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    public static class Extensions
    {
        public static Student ByName(this Student[] arr,string name)
        {
            var searchedFor = arr.Where(s => s.Name == name).ToArray();
            if (searchedFor.Length > 0)
            {
                return searchedFor[0];
            }

            return Student.Default();
        }
    }
}
