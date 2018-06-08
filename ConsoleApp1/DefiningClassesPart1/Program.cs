using System;

namespace DefiningClassesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhone = new GSM("Galaxy S5","Stoyan CO",999,"Stoyan",3,2,BatteryType.LiIon,166,3);

            Console.WriteLine(myPhone.ToString());
        }
    }
}
