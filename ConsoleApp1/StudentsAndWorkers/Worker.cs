using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private Decimal WeekSalary { get; set; }
        private int WorkHoursPerDay { get; set; }

        public Worker(string fName,string lName,Decimal weekSalary, int workHoursPerDay) : base(fName,lName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public Decimal MoneyPerHour()
        {
            return (WeekSalary / 7) / WorkHoursPerDay;
        }
    }
}
