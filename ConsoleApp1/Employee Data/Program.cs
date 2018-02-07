using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //A marketing company wants to keep record of its employees. Each record would have the following characteristics:

            //First name
            //Last name
            //Age(0...100)
            //Gender(m or f)
            //Personal ID number(e.g. 8306112507)
            //Unique employee number(27560000…27569999)
            //Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
            //Use descriptive names.Print the data at the console.


            string persone0firstname = "Stoyan";
            string persone0lastname = "Kolev";
            int persone0age = 17;
            string persone0gender = "Male";
            long persone0id = 8306112507;
            int persone0number = 27560000;


            Console.WriteLine(persone0firstname);
            Console.WriteLine(persone0lastname);
            Console.WriteLine(persone0age);
            Console.WriteLine(persone0gender);
            Console.WriteLine(persone0id);
            Console.WriteLine(persone0number);
        }

    }
}
