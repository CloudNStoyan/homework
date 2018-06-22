using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student(1, "Stoyan", "Kolev"),
                new Student(1, "Gosho", "Peshev"),
                new Student(3, "Pesho", "Stringov"),
                new Student(2, "Reno", "Jackson"),
                new Student(2, "Ivan", "Petkanov"),
                new Student(4, "Valeri", "Petrov"),
                new Student(4, "Pavel", "Peshev"),
                new Student(3, "Edward", "Stringov"),
                new Student(2, "Murlund", "Jackson"),
                new Student(2, "Kehman", "Petkanov")
            };

            students = students.OrderBy(s => s.Grade).ToList();

            var workers = new List<Worker>
            {
                new Worker("Geroff","Nesh si",700,8),
                new Worker("Pesho","Virimov",800,6),
                new Worker("Andy","Ersp",960,8),
                new Worker("Angel","Limonov",500,6),
                new Worker("Grash","Evenis si",7000,10),
                new Worker("Garosh","Hellscream",2400,8),
                new Worker("Mitko","Tribunov",500,3),
                new Worker("Nasko","Rusnalov",5500,9),
                new Worker("Ahmed","Ahmedov",1000,6),
                new Worker("Franko","Asyber",690,6)
            };

            workers = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();


            var merged = new List<Human>();

            foreach (var st in students)
            {
                merged.Add(st);
            }

            foreach (var worker in workers)
            {
                merged.Add(worker);
            }

            merged = merged.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();

            foreach (var human in merged)
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }

        }

        static void PrintStudents(List<Student> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine(student.Grade);
            }
        }

        static void PrintWorkers(List<Worker> list)
        {
            foreach (var worker in list)
            {
                Console.WriteLine(worker.MoneyPerHour());
            }
        }
    }
}
