using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _16.Date_difference
{
    class Program
    {
        static void Main()
        {
            ////Example from stack overflow
            ////https://stackoverflow.com/questions/3993520/c-initialize-a-datetime-array
            //DateTime [] startDate = new DateTime[5];
            //       startDate[0] = new DateTime(11, 11, 10);
            //       startDate[1] = new DateTime(11, 11, 10);
            //       startDate[2] = new DateTime(11, 11, 10);
            //       startDate[3] = new DateTime(11, 11, 10);
            //       startDate[4] = new DateTime(11, 11, 10);


            ////I use Microsoft documentation
            ////https://msdn.microsoft.com/en-us/library/w2sa9yss(v=vs.110).aspx
            string[] dateinput ={"27.02.2006", "3.03.2006"};
            string format = "";
            DateTime[] calulation = new DateTime[dateinput.Count()];

            CultureInfo provider = CultureInfo.InvariantCulture;
            int timespan = 0;

            for (int i = 0; i < dateinput.Count(); i++)
            {
                format = "dd.MM.yyyy";
                try
                {
                    calulation[i] = DateTime.ParseExact(dateinput[i], format, provider);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not in the correct format.", dateinput[i]);
                }

                format = "d.MM.yyyy";
                try
                {
                    calulation[i] = DateTime.ParseExact(dateinput[i], format, provider);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not in the correct format.", dateinput[i]);
                }
            }
            timespan = calulation[1].DayOfYear - calulation[0].DayOfYear;
            Console.WriteLine("Distance: {0} days", timespan);
        }
    }
}
