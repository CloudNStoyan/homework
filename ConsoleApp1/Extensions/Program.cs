using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Extensions
{
    class Program
    {
        class SomeStudent
        {
            private string FirstName;
            private string LastName;
            private int StudentAge;

            public SomeStudent(string fName, string sName, int age)
            {
                FirstName = fName;
                LastName = sName;
                StudentAge = age;
            }

            public string Name
            {
                get { return FirstName; }
            }

            public string FamilyName
            {
                get { return LastName; }
            }

            public int Age
            {
                get { return StudentAge; }
            }

        }

        class Student
        {
            private string FirstName;
            private string LastName;
            private int FN;
            private string Tel;
            private string Email;
            private string Marks;
            private int GroupNumber;

            public Student(string fName, string lName, int fn, string tel, string email, string marks, int groupNumber)
            {
                FirstName = fName;
                LastName = lName;
                FN = fn;
                Tel = tel;
                Email = email;
                Marks = marks;
                GroupNumber = groupNumber;
            }

            public int GroupNum
            {
                get { return GroupNumber; }

            }

            public string Name
            {
                get { return $"{FirstName} {LastName}"; }
            }

            public string Mail
            {
                get { return Email; }
            }

            public string PhoneNumber
            {
                get { return Tel; }
            }
        }

        delegate void TimerPredicate(string text);


        static void Main(string[] args)
        {
            Student Stoyan = new Student("Stoyan","Rex",29,"+35924141","slowness@abv.bg","Stuff",4);
            Student Kaloqn = new Student("Kaloqn", "Erwicht", 31, "+35944141", "sasdasdasda@gmail.bg", "Stuff", 2);
            Student Pesho = new Student("Pesho", "Grung", 4432, "+35984141", "nww@cmd.eu", "Stuff", 2);
            Student Jordan = new Student("Jordan", "Esnicht", 229, "0214141", "erw@abv.bg", "Stuff", 3);
            Student Tosho = new Student("Tosho", "Bulev", 25, "+35914141", "sle@abv.bg", "Stuff", 1);

            var MyStudents = new Student[] {Stoyan, Kaloqn, Jordan, Pesho, Tosho};

            var arr2 = ExtractByPhone(MyStudents, "2");
            foreach (var student in arr2)
            {
                Console.WriteLine(student.Name);
            }
        }



        static void SetInterval(int second, TimerPredicate predicate)
        {
            Timer timer = new Timer(second * 1000);
            timer.AutoReset = true;
            timer.Elapsed += (sender, e) => EventHandler(sender, e,predicate);
            timer.Start();
        }

        static void EventHandler(Object source, ElapsedEventArgs e, TimerPredicate predicate)
        {
            predicate("Das Vas Eine");
        }

        static void PrintString(string text)
        {
            Console.WriteLine(text);
        }



        static List<Student> ExtractByPhone(Student[] arr, string cityCode)
        {
            return arr.Where(student => student.PhoneNumber.StartsWith($"+359{cityCode}") || student.PhoneNumber.StartsWith($"0{cityCode}"))
                .ToList();
        }

        static List<Student> ExtractByMail(Student[] arr,string mail)
        {
            return arr.Where(student => student.Mail.EndsWith(mail)).ToList();
        }

        static List<Student> FromGroup(Student[] arr, int gn)
        {
            return arr.Where(student => student.GroupNum == gn).ToList();
        }

        static string[] FirstBeforeLast(string[] arr)
        {
            return arr.Where(name => string.Compare(name.Split(' ')[0], name.Split(' ')[1]) > 0).OrderBy(name => name).ToArray();
        }

        static string[] AgeRange(SomeStudent[] arr)
        {
            return arr.Where(student => student.Age >= 18 && student.Age <= 24).Select(student => $"{student.Name} {student.FamilyName}").ToArray();
        }

        static SomeStudent[] OrderSomeStudents(SomeStudent[] arr)
        {
            return arr.OrderByDescending(student => student.Name).ThenByDescending(student => student.FamilyName).ToArray();
        }

        static int[] DivisibleBy7And3(int[] numbers)
        {
            return numbers.Where(number => number % 7 == 0 && number % 3 == 0).ToArray();
        }
        

    }
}
