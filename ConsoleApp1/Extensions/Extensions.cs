using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ExtensionStringBuild
    {
        public static StringBuilder Substring(this StringBuilder builder,int index,int length)
        {
            string text = builder.ToString();
            text = text.Substring(index, length);

            return new StringBuilder(text);
        }

        /*static void GroupedByGroupNumber(int groupNum, Student[] arr)
        {
            var arr2 = arr.Where(student => student.GroupNumber.GroupNumber == groupNum)
                .Select(student => $"{student.FirstName} {student.LastName}").ToArray();

            Console.WriteLine(String.Join(", ",arr2));
        }*/

        //Rewrite the previous using extension methods.


        public static void GroupName(this Program.Student[] arrStudents, string name)
        {
            var arr2 = arrStudents.Where(student => student.GroupNumber.DepartmentName == name)
                .Select(s => $"{s.FirstName} {s.LastName}").ToArray();

            Console.WriteLine(String.Join(", ",arr2));
        }
    }
}
