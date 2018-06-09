using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesPart1
{

    public class Baterry
    {
        private int HoursIdle = 0;
        private int HoursTalk = 0;
        private BatteryType Type = BatteryType.LiIon;


        public Baterry(int hoursIdle, int hoursTalk, BatteryType type)
        {
            HoursIdle = hoursIdle;
            HoursTalk = hoursTalk;
            Type = type;
        }

        public int GetHoursIdle
        {
            get { return HoursIdle;  }
        }

        public int GetHoursTalk
        {
            get { return HoursTalk; }
        }

        public BatteryType GetType
        {
            get { return Type; }
        }
    }

    public class Display
    {
        private double Size = 0;
        private int NumberOfCalors = 0;

        public double GetSize
        {
            get { return Size; }
        }

        public int GetNumberOfColors
        {
            get { return NumberOfCalors; }
        }

        public Display(double size, int numberOfColors)
        {
            Size = size;
            NumberOfCalors = numberOfColors;
        }
    }

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    public class GSM
    {
        public string Model = null;

        public string Manufacturer = null;

        public double Price = 0;

        public string Owner = null;

        public static GSM IPhone4S = new GSM("Iphone4S","Apple",1499,"Stoyan",100,50,BatteryType.NiMH,1260,2);

        public GSM(string model,string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;    
        }


        public Display Display { get; set; }

        public Baterry Battery { get; set; }


        public GSM(string model, string manufacturer, double price, string owner,
            int batteryHoursIdle, int batteryHoursTalk,BatteryType type, double displaySize, int displayNumberOfColors)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            this.Battery = new Baterry(batteryHoursIdle,batteryHoursTalk,type);
            this.Display = new Display(displaySize,displayNumberOfColors);
        }


        public string Print()
        {
            return $"{Model}\n{Manufacturer}\n{Price}\n{Owner}\n{Display.GetSize}\n{Display.GetNumberOfColors}\n{Battery.GetHoursIdle}\n{Battery.GetHoursTalk}\n{Battery.GetType}";
        }

        public override string ToString()
        {
            return Print();
        }
    }
}
