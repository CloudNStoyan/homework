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
            return $"Model:{Model}\nManufacturer:{Manufacturer}\nPrice:{Price}$\nOwner:{Owner}\nDisplay Size:{Display.GetSize}\nDisplay Number of colors:{Display.GetNumberOfColors}\nHours idle:{Battery.GetHoursIdle}\nHours talk:{Battery.GetHoursTalk}\nBattery type:{Battery.GetType}";
        }

        public override string ToString()
        {
            return Print();
        }
    }

    public class GSMTest
    {
        public GSMTest()
        {

        }

        public void Test()
        {
            GSM[] Phones = new GSM[3];
            Phones[0] = new GSM("Safari", "Antilop", 20, "Kapitan Skrutz", 3, 5, BatteryType.LiIon, 480, 1);
            Phones[1] = new GSM("GalaxyJ5", "Samsung", 300, "Stoyan", 80, 24, BatteryType.LiIon, 1600, 3);
            Phones[2] = new GSM("Note8", "Samsung", 700, "Atanas", 120, 53, BatteryType.NiMH, 2120, 4);
            foreach (GSM phone in Phones)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
