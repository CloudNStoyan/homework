using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student("Stoyan","Antonov","Kolev","nz","Nqkva ulica 15","+356000332","stoqn.game@abv.bg","C# OOP",Specialty.Javascript,University.TelerikAcademy,Faculty.First);
            Student mySecondStudent = new Student("Stoyan", "Antonov", "Kolev", "nz", "Nqkva ulica 15", "+356000332", "stoqn.game@abv.bg", "C# OOP", Specialty.Javascript, University.TelerikAcademy, Faculty.First);


            Console.WriteLine(myStudent != mySecondStudent);
        }
    }
}
