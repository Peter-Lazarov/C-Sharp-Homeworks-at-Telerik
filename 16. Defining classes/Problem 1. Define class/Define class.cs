using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Define_class
{
    class Program
    {
        static void Main()
        {
            //GSM Nokia = new GSM("3310", "Nokia");
            //Nokia.Owner = "chicho Pesho";
            //Nokia.Price = 210;

            //Nokia.BatteryHoursIdle = 336;
            //Nokia.BatteryHoursTalk = 40;
            //Nokia.BatteryModel = "battery for Nokia 3200mAh";

            //Nokia.DisplayColors = 16000000;
            //Nokia.DisplaySize = 5.5;

            //Console.WriteLine(Nokia.ToString());

            //Console.WriteLine();
            //GSMTest.Print();
            //Console.WriteLine();

            ////Problem 8
            //Call toSomeone = new Call();
            //toSomeone.Answer(0898282842);
            //Thread.Sleep(2000);
            //toSomeone.Close();

            //Console.WriteLine(toSomeone.Date);
            //Console.WriteLine(toSomeone.Time);
            //Console.WriteLine(toSomeone.Duration);

            //////Problem 9 run test

            //Console.WriteLine();
            //Console.WriteLine("Test for initialisation of class thru property");
            //Console.WriteLine(GSM.History[0].Date);
            //Console.WriteLine(GSM.History[0].Time);
            //Console.WriteLine(GSM.History[0].Duration);
            //Console.WriteLine(GSM.History[0].PhoneNumber);

            //Call toSomeone2 = new Call();
            //toSomeone.Answer(0898282842);
            //Thread.Sleep(2000);
            //toSomeone.Close();

            //Console.WriteLine(GSM.History[1].Date);
            //Console.WriteLine(GSM.History[1].Time);
            //Console.WriteLine(GSM.History[1].Duration);
            //Console.WriteLine(GSM.History[1].PhoneNumber);

            //GSM.AddCalls("11.12.2017", "10:53:28", 0898282842, "00:01:29");

            ////Console.WriteLine(GSM.History[0].Date);
            ////GSM.DeleteCalls(1);

            //Console.WriteLine("Point 11");
            //Console.WriteLine(GSM.CallSum());

            Console.WriteLine("Point 12");
            CallHistoryTest.Enter();
            CallHistoryTest.Print();
            CallHistoryTest.Dothings();
            CallHistoryTest.Print();
        }
    }
}
