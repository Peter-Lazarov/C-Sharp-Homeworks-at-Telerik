using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19.Dates_from_text_in_Canada
{
    class Program
    {
        static void Main()
        {
            string[] dateinput = { "27.02.2006" };
            string format = "";
            DateTime[] calulation = new DateTime[dateinput.Count()];

            CultureInfo provider = CultureInfo.InvariantCulture;
            //provider = new CultureInfo("en-CA");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

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
            //CultureInfo.InvariantCulture;

            Console.WriteLine(calulation[0]);
        }
    }
}
