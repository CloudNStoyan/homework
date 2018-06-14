using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        class Student
        {
            private string FirstName;
            private string SecondName;
            private int StudentAge;

            public Student(string fName, string sName, int age)
            {
                FirstName = fName;
                SecondName = sName;
                StudentAge = age;
            }

            public string Name 
            {
                get { return FirstName; }
            }

            public string FamilyName
            {
                get { return SecondName; }
            }

            public int Age
            {
                get { return StudentAge; }
            }

        }


        static void Main(string[] args)
        {

        }

        static string[] FirstBeforeLast(string[] arr)
        {
            return arr.Where(name => string.Compare(name.Split(' ')[0], name.Split(' ')[1]) > 0).OrderBy(name => name).ToArray();
        }

        static string[] AgeRange(Student[] arr)
        {
            return arr.Where(student => student.Age >= 18 && student.Age <= 24).Select(student => $"{student.Name} {student.FamilyName}").ToArray();
        }

        static Student[] OrderStudents(Student[] arr)
        {
            return arr.OrderByDescending(student => student.Name).ThenByDescending(student => student.FamilyName).ToArray();
        }

        static int[] DivisibleBy7And3(int[] numbers)
        {
            return numbers.Where(number => number % 7 == 0 && number % 3 == 0).ToArray();
        }
        
    }
}
