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
    public class Program
    {

        public class Group
        {
            public int GroupNumber { get; private set; }
            public string DepartmentName { get; private set; }

            public Group(int gNum, string departName)
            {
                GroupNumber = gNum;
                DepartmentName = departName;
            }
        }

        public class Student
        {
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public int FN { get; private set; }
            public string Tel { get; private set; }
            public string Email { get; private set; }
            public List<int> Marks { get; private set; }
            public Group GroupNumber { get; private set; }

            private Dictionary<int, Group> Groups = new Dictionary<int, Group>()
            {
                {1, new Group(1,"Art")},
                {2, new Group(2,"Math")},
                {3, new Group(3, "Web")}
            };

            public Student(string fName, string lName, int fn, string tel, string email, List<int> marks, int groupNumber)
            {
                FirstName = fName;
                LastName = lName;
                FN = fn;
                Tel = tel;
                Email = email;
                Marks = marks;
                GroupNumber = Groups[groupNumber];
            }
        }

        delegate void TimerPredicate(string text);


        static void Main(string[] args)
        {
            Student Stoyan = new Student("Stoyan","Rex",294306,"+35924141","slowness@abv.bg",new List<int>(){ 2 ,2 ,5 },2);
            Student Kaloqn = new Student("Kaloqn", "Erwicht", 294306, "+35944141", "sasdasdasda@gmail.bg", new List<int>() { 6, 4, 5 }, 2);
            Student Tosho = new Student("Tosho", "Bulev", 294316, "+35914141", "sle@abv.bg", new List<int>() { 2, 2, 3,6 }, 1);
            Student Pesho = new Student("Pesho", "Grung", 294352, "+35984141", "nww@cmd.eu", new List<int>() { 2, 6, 5 }, 2);
            Student Jordan = new Student("Jordan", "Esnicht", 293305, "0214141", "erw@abv.bg", new List<int>() { 2, 5, 5 }, 3);

            var MyStudents = new Student[] {Stoyan, Kaloqn, Jordan, Pesho, Tosho};

            var arr = MyStudents.StudentGroups();

            foreach (var student in arr)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

        }

        static void GroupedByGroupNumber(int groupNum, Student[] arr)
        {
            var arr2 = arr.Where(student => student.GroupNumber.GroupNumber == groupNum)
                .Select(student => $"{student.FirstName} {student.LastName}").ToArray();

            Console.WriteLine(String.Join(", ",arr2));
        }

        static string ExtractGroups(Student[] arr)
        {
            var arr2 = arr.Where(student => student.GroupNumber.DepartmentName == "Math")
                .Select(student => $"{student.FirstName} {student.LastName}").ToArray();
            return string.Join(", ",arr2);
        }

        static dynamic[] ExtractByMarks(Student[] arr)
        {
            arr = arr.Where(student => student.Marks.Contains(6)).ToArray();
            
            dynamic[] myStudents = new dynamic[arr.Length];
            for (int i = 0; i < myStudents.Length; i++)
            {
                myStudents[i] = new {FullName = $"{arr[i].FirstName} {arr[i].LastName}", Marks = arr[i].Marks};
            }

            return myStudents;

        }

        static List<List<int>> ExtractMarks(Student[] arr)
        {
            return arr.Where(student => student.FN.ToString().EndsWith("06")).Select(student => student.Marks).ToList();
        }


        static string GetLargest(string[] arr)
        {
            arr = arr.OrderByDescending(s => s.Length).ToArray();
            return arr[0];
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
            return arr.Where(student => student.Tel.StartsWith($"+359{cityCode}") || student.Tel.StartsWith($"0{cityCode}"))
                .ToList();
        }

        static List<Student> ExtractByMail(Student[] arr,string mail)
        {
            return arr.Where(student => student.Email.EndsWith(mail)).ToList();
        }

        static List<Student> FromGroup(Student[] arr, int gn)
        {
            return arr.Where(student => student.GroupNumber.GroupNumber == gn).ToList();
        }

        static string[] FirstBeforeLast(string[] arr)
        {
            return arr.Where(name => string.Compare(name.Split(' ')[0], name.Split(' ')[1]) > 0).OrderBy(name => name).ToArray();
        }

        static int[] DivisibleBy7And3(int[] numbers)
        {
            return numbers.Where(number => number % 7 == 0 && number % 3 == 0).ToArray();
        }
        

    }
}
