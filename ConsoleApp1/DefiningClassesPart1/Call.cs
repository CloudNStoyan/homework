using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesPart1
{
    class Call
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
    }
}
