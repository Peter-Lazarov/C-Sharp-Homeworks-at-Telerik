using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsandWorkers
{
    public class Worker : Human
    {
        public decimal wSalary { get; set; }
        public decimal workedH { get; set; }

        public static List<Worker> AllWorkers = new List<Worker>();
        public Worker()
        {
        }
        public Worker(string fname, string lname, decimal weekSalary, decimal workedHours) : base(fname, lname)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.wSalary = weekSalary;
            this.workedH = workedHours;
            AllWorkers.Add(this);
        }
        public decimal MoneyPerHour()
        {
            decimal money = this.wSalary / (this.workedH * 5);
            money = Math.Round(money, 2);
            return money;
        }
        public override string ToString()
        {
            string overWritten = string.Format("{0} {1} {2} {3} {4}", this.firstName, this.lastName, this.wSalary, this.workedH, this.MoneyPerHour());
            return overWritten;
        }
    }
}
