using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesPart1
{
    class GSM
    {
        public string Model;
        public string Manufacturer;
        public double Price = 0;
        public string Owner = null;

        public class Baterry
        {
            public string BatteryModel = null;
            public int HoursIdle = 0;
            public int HoursTalk = 0;

            public Baterry(string batteryModel, int hoursIdle, int hoursTalk)
            {
                BatteryModel = batteryModel;
                HoursIdle = hoursIdle;
                HoursTalk = hoursTalk;
            }
        }

        public class Display
        {
            public double Size = 0;
            public int NumberOfCalors = 0;

            public Display(double size, int numberOfColors)
            {
                Size = size;
                NumberOfCalors = numberOfColors;
            }
        }

        public GSM(string model,string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, int price, string owner, string batteryModel,
            int batteryHoursIdle, int batteryHoursTalk, double displaySize, int displayNumberOfColors)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            var battery = new Baterry(batteryModel,batteryHoursIdle,batteryHoursTalk);
            var display = new Display(displaySize,displayNumberOfColors);
        }

    }
}
