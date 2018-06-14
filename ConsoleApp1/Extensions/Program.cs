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
            var StudentOne = new Student("Stoyan","Kolev",10);
            var StudentTwo = new Student("Ahmed","Ahmedov",20);

            var arrOfStudents = new Student[] {StudentOne, StudentTwo};

        }

        static string[] FirstBeforeLast(string[] arr)
        {
            return arr.Where(name => string.Compare(name.Split(' ')[0], name.Split(' ')[1]) > 0).OrderBy(name => name).ToArray();
        }

        static string[] AgeRange(Student[] arr)
        {
            return arr.Where(student => student.Age >= 18 && student.Age <= 24).Select(student => $"{student.Name} {student.FamilyName}").ToArray();
        }
        
    }
}
