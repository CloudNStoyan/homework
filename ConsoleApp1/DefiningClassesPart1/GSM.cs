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
        public List<Call> CallHistory = new List<Call>();

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

        public void AddCall(string date, string time, string number, int duration)
        {
            CallHistory.Add(new Call(date,time,number,duration));
            Console.WriteLine("Call created!");
        }

        public void DelCall(string date, string time, string number, int duration)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].GetCall() == $"{date},{time},{number},{duration}")
                {
                    string callInfo = CallHistory[i].GetCall();
                    CallHistory.RemoveAt(i);
                    Console.WriteLine($"Call: {callInfo} is deleted!");
                    return;
                }
            }

            Console.WriteLine("No call was found!");
        }

        public void DelCall(Call call)
        {
            if (CallHistory.Contains(call))
            {
                string callInfo = call.GetCall();
                CallHistory.Remove(call);
                Console.WriteLine($"Call: {callInfo} is deleted!");
            }
            else
            {
                Console.WriteLine("No call was found!");
            }
        }

        public void ClearCallHistory()
        {
            CallHistory = new List<Call>();
            Console.WriteLine("CallHistory cleared!");
        }

        public void PrintCallHistory()
        {
            foreach (Call call in CallHistory)
            {
                Console.WriteLine(call.GetCall());
            }
        }

        public void PriceOfCalls(double price)
        {
            double wholeDuration = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                wholeDuration += int.Parse(CallHistory[i].GetCall().Split(',')[3]);
            }

            Console.WriteLine((Math.Ceiling(wholeDuration / 60) * price) + "$");
        }
    }

    public class Call
    {
        private string Date;
        private string Time;
        private string Number;
        private int Duration;

        public Call(string date, string time, string number, int duration)
        {
            Date = date;
            Time = time;
            Number = number;
            Duration = duration;
        }

        public string GetCall()
        {
            return $"{Date},{Time},{Number},{Duration}";
        }
    }

    public class GSMTest
    {
        public GSMTest()
        {

        }

        public void Start()
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

    public class GSMCallHistoryTest
    {
        public GSMCallHistoryTest()
        {

        }

        public void Start()
        {
            GSM phone = new GSM("GalaxyJ5", "Samsung", 300, "Stoyan", 80, 24, BatteryType.LiIon, 1600, 3);
            phone.AddCall("29.05","12:13","0888015508",167);
            phone.AddCall("29.05","13:25","0888015508",305);
            phone.AddCall("30.05","06:03","290501515",12);

            foreach (Call call in phone.CallHistory)
            {
                Console.WriteLine(call.GetCall());
            }

            phone.PriceOfCalls(0.37);

            int longestCall = 0;
            int longestCallIndex = 0;
            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                int callDuration = int.Parse(phone.CallHistory[i].GetCall().Split(',')[3]);
                if (callDuration > longestCall)
                {
                    longestCall = callDuration;
                    longestCallIndex = i;
                }
            }

            phone.DelCall(phone.CallHistory[longestCallIndex]);

            phone.PriceOfCalls(0.37);
            phone.PrintCallHistory();
            phone.ClearCallHistory();
        }
    }
}
