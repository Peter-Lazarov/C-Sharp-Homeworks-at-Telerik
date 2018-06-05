using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_class
{
    class CallHistoryTest
    {
        public static void Enter() 
        {
            GSM.AddCalls("11.12.2017", "10:53:28", 0898282842, "00:01:29");
            GSM.AddCalls("15.12.2017", "12:43:28", 0898243245, "00:02:42");
            GSM.AddCalls("16.12.2017", "15:25:28", 0894983839, "00:00:42");
        }
        public static void Print()
        {
            int i = 1;
            foreach (var item in GSM.History)
            {
                Console.WriteLine();
                Console.WriteLine("Call {0}", i);
                Console.WriteLine(item.Date);
                Console.WriteLine(item.Time);
                Console.WriteLine(item.Duration);
                Console.WriteLine(item.PhoneNumber);
                i++;
            }
            Console.WriteLine("");
        }
        public static void Dothings()
        {
            Console.WriteLine(GSM.CallSum());
            GSM.DeleteLongestCall();
            Console.WriteLine(GSM.CallSum());
            while (GSM.History.Count() > 0)
            {
                GSM.DeleteCalls(0);
            }
        }
    }
}
