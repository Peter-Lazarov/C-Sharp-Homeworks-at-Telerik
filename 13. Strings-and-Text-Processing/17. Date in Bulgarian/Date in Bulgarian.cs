using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.Date_in_Bulgarian
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
            //the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

            string datein = "9.10.17 17:57:31";//"19.октомври.2017 17:57:31";
            DateTime time = DateTime.Now;

            string format = "";
            string result = "";
            string day = "";         

            CultureInfo provider = new CultureInfo("bg-BG");//CultureInfo.InvariantCulture;

            format = "d.MMMM.yyyy HH:mm:ss";
            try
            {
                time = DateTime.ParseExact(datein, format, provider);
            }
            catch (Exception)
            {
            }

            format = "d.MM.yyyy HH:mm:ss";
            try
            {
                time = DateTime.ParseExact(datein, format, provider);
            }
            catch (Exception)
            {
            }

            format = "d.MM.yy HH:mm:ss";
            try
            {
                time = DateTime.ParseExact(datein, format, provider);
            }
            catch (Exception)
            {
            }
            result = time.AddHours(6.5).ToString();

            day = DateTimeFormatInfo.CurrentInfo.GetDayName(time.AddHours(6.5).DayOfWeek);
            Console.WriteLine("{0} {1}",result,day);
        }
    }
}
