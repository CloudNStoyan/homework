using System;

namespace DefiningClassesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhone = new GSM("Galaxy J5","Samsung",300,"Stoyan",128,50,BatteryType.LiIon,1600,3);

            myPhone.AddCall("06.04","23:11","0878015008",167);
            myPhone.DelCall("06.04", "23:11", "0878015008", 167);
        }
    }
}
