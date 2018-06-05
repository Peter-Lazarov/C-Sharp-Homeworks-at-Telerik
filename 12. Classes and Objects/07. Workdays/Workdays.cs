using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Workdays
{
    class Workdays
    {
        static int isWorkday(DayOfWeek weekday)
        {
            if ((weekday != DayOfWeek.Saturday) && (weekday != DayOfWeek.Sunday))
            {
                return 1;   
            }
            return 0;
        }
        static int isHoliday(string year, int start, int end,int stage)
        {
            string[] holidays = { "01.01." + year,
                                    "03.03." + year,
                                    "01.05." + year,
                                    "06.09." + year, 
                                    "22.09." + year, 
                                    "01.11." + year,
                                    "24.12." + year,
                                    "25.12." + year,
                                    "26.12." + year,
                                    "30.12." + year,
                                    "31.12." + year};
            int[] number = new int[holidays.Count()];
            int holiday = 0;
            if (stage == 1)
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    DateTime hdays = Convert.ToDateTime(holidays[i]);
                    number[i] = hdays.DayOfYear;
                    if (number[i] >= start)
                    {
                        holiday += isWorkday(hdays.DayOfWeek);
                    }
                }
            }
            else if (stage == -1)
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    DateTime hdays = Convert.ToDateTime(holidays[i]);
                    number[i] = hdays.DayOfYear;
                    if (number[i] <= end)
                    {
                        holiday += isWorkday(hdays.DayOfWeek);
                    }
                }
            }
            else if (stage == 0)
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    DateTime hdays = Convert.ToDateTime(holidays[i]);
                    number[i] = hdays.DayOfYear;
                    if ((number[i] >= start) && (number[i] <= end))
                    {
                        holiday += isWorkday(hdays.DayOfWeek);
                    }
                }
            }            
            return holiday;
        }
        static void Main()
        {
            
            
            //DateTime.ParseExact("23.10.2017", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string begin = "01.01.2017";
            string end = "31.12.2022";
            DateTime beginDate = Convert.ToDateTime(begin);
            DateTime endDate = Convert.ToDateTime(end);
            DateTime beginDate2 = beginDate;
            DateTime endDate2 = endDate;
            int workdays = 0;
            int yperiod = endDate.Year - beginDate.Year;
            int mid = 1;
            
            if (yperiod >= 2)
            {
                workdays -= isHoliday(Convert.ToString(beginDate.Year), beginDate.DayOfYear, endDate.DayOfYear,1);
                while (yperiod > mid)
                {
                    workdays -= isHoliday(Convert.ToString(beginDate.Year + mid), 1, new DateTime(beginDate.Year+mid, 12, 31).DayOfYear, 0);
                    mid++;
                }
                workdays -= isHoliday(Convert.ToString(endDate.Year), endDate.DayOfYear, endDate.DayOfYear, -1);
            }
            else if (yperiod == 1)
            {
                workdays -= isHoliday(Convert.ToString(beginDate.Year), beginDate.DayOfYear, endDate.DayOfYear,1);
                workdays -= isHoliday(Convert.ToString(endDate.Year), endDate.DayOfYear, endDate.DayOfYear, -1);
            }
            else if (yperiod == 0)
            {
                workdays -= isHoliday(Convert.ToString(beginDate.Year), beginDate.DayOfYear, endDate.DayOfYear, 0);
            }

            while (beginDate2.DayOfWeek != DayOfWeek.Monday)
            {
                workdays += isWorkday(beginDate2.DayOfWeek);
                beginDate2 = beginDate2.AddDays(1);
            }
            while (endDate2.DayOfWeek != DayOfWeek.Monday)
            {
                workdays += isWorkday(endDate2.DayOfWeek);
                endDate2 = endDate2.AddDays(-1);
            }

            int period = (endDate2 - beginDate2).Days;
            int workvar = (period / 7) * 5;
            workdays += workvar;
            Console.WriteLine(workdays);
        }
    }
}
