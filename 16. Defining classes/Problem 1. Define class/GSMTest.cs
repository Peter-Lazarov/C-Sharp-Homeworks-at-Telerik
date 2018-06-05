using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_class
{
    class GSMTest
    {
        //Create an array of few instances of the GSM class.
        //Display the information about the GSMs in the array.
        //Display the information about the static property IPhone4S.
        public static void Print()
        {
            GSM NokiaLumia = new GSM("Lumia", "Nokia", 330, "John", 24, 5, "Lumiabattery", 5.5, 16000000);
            GSM Siemens = new GSM("S65", "Siemens", 600, "Todor", 100, 8, "S65battery", 3.5, 160);
            GSM Sony = new GSM("K800", "Sony", 800, "Pesho", 180, 12, "K800battery", 4.0, 32000000);

            GSM[] magazin = new GSM[] { NokiaLumia, Siemens, Sony };

            for (int i = 0; i < magazin.Count(); i++)
            {
                Console.WriteLine(magazin[i].ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSM.IPhone4s);
        }
    }

}
