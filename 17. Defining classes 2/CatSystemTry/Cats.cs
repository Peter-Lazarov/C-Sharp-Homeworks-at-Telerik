using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystemTry
{
    class Cats
    {
        private string color;

        public Cats(string cviat)
        {
            this.color = cviat;
        }

        public string name { get; set; }
        public int Age { get; set; }
        public Owner Sobstvenik { get; set; }
    }
}
