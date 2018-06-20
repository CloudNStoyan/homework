using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    class Startup
    {
        static void Main()
        {
            var mainDisciplines = new Discipline[] { new Discipline("Mathematic", 4, 5), new Discipline("Art", 2, 2) };
            var lifeDisciplines = new Discipline[] { new Discipline("Chemistry", 10, 20), new Discipline("Biology", 2, 2) };
            
            var pgeeTeachers = new Teachers[] { new Teachers("Ivan", 23, mainDisciplines), new Teachers("Petko", 24, lifeDisciplines) };
            var students = new Student[] {new Student("Pesho", 18, 96853), new Student("Stoyan", 17, 87524)};


            var school = new School("Pgee","Life&Main",pgeeTeachers,students);

            var a = school.Students.ByName("Peshao");
            Console.WriteLine(a.Name);

            a.Add("Dwarfs");
            pgeeTeachers[0].Add("String");
            school.Add("string");

            Console.WriteLine(school.SchoolComments[0]);
        }
    }
}
