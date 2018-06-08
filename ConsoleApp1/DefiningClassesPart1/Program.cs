using System;

namespace DefiningClassesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhone = new GSM();
            var myBattery = new GSM.Baterry();
            var myDisplay = new GSM.Display();

            myPhone.owner = "Stoyan";
            myBattery.hoursIdle = 3;
            myBattery.hoursTalk = 2;
            myPhone.manufacturer = "Stoyan CO";
            myDisplay.numberOfCalors = 2;
            myDisplay.size = 166;
            myPhone.model = "Galaxy S5";
            myPhone.price = 929.99;
        }
    }
}
