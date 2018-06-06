using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesPart1
{
    class MobilePhone
    {
        public string model;
        public string manufacturer;
        public double price;
        public string owner;

        public string modelOfBattery;
        public int hoursIdle;
        public int hoursTalk;
        public double size;
        public int numberOfCalors;


        public override string ToString()
        {
            return
                $"Model: {model}\nManufacturer: {manufacturer}\nPrice: {price}\nOwner: {owner}\n//Battery\nModel: {modelOfBattery}\nHours idle: {hoursIdle}\nHours talk: {hoursTalk}\nSize: {size}\nColors: {numberOfCalors}";
        }
    }
}
