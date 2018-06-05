using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Timer
{
    class StartFile
    {
        static void Main()
        {
            //7. Using delegates write a class Timer that can execute certain method at each t seconds.
            var tryDelegate = new Timer.delegateWork(Timer.doSomething);
            tryDelegate(5);
        }
    }
}
