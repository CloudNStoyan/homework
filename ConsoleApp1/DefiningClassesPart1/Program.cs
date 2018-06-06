using System;

namespace DefiningClassesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhone = new MobilePhone();

            myPhone.owner = "Stoyan";
            myPhone.hoursIdle = 3;
            myPhone.hoursTalk = 2;
            myPhone.manufacturer = "Stoyan CO";
            myPhone.modelOfBattery = "PS22287";
            myPhone.numberOfCalors = 2;
            myPhone.size = 166;
            myPhone.model = "Galaxy S5";
            myPhone.price = 929.99;


            Console.WriteLine(myPhone.ToString());
        }
    }
}
