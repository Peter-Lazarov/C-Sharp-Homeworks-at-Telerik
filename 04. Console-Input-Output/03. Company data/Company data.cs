using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_data
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please give us company information");
            Console.WriteLine("Company name");
            string cname = Console.ReadLine();
            Console.WriteLine("Company address");
            string caddress = Console.ReadLine();
            Console.WriteLine("Company phone number");
            string cphone = Console.ReadLine();
            Console.WriteLine("Company fax number");
            string cfax = Console.ReadLine();
            Console.WriteLine("Company web site");
            string cweb = Console.ReadLine();
            Console.WriteLine("Company Manager first name");
            string mname = Console.ReadLine();
            Console.WriteLine("Company Manager last name");
            string mlname = Console.ReadLine();
            Console.WriteLine("Company Manager age");
            string mage = Console.ReadLine();
            Console.WriteLine("Company Manager phone");
            string mphone = Console.ReadLine();

            Console.WriteLine("Company name is {0}", cname);
            Console.WriteLine("Company address is {0}", caddress);
            Console.WriteLine("Company phone number is {0}", cphone);
            Console.WriteLine("Company fax number is {0}", cfax);
            Console.WriteLine("Company web site is {0}", cweb);
            Console.WriteLine("Company Manager first name is {0}", mname);
            Console.WriteLine("Company Manager last name is {0}", mlname);
            Console.WriteLine("Company Manager age is {0}", mage);
            Console.WriteLine("Company Manager phone is {0}", mphone);
        }
    }
}
