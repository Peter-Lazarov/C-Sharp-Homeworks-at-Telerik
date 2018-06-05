using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace BankAccounts
{
    class StartPoint
    {
        static void Main()
        {
            Deposit Pesho = new Deposit(Customers.Individual, 1200, 5);

            Console.WriteLine(Pesho.Amound);
            Console.WriteLine(Pesho.InterestforMonth);

            Deposit GoshoCO = new Deposit(Customers.Company, 2330, 45);
            Console.WriteLine(GoshoCO.customerType);
            Console.WriteLine();

            Loan Ivan = new Loan(Customers.Company, 500, 2);
            Console.WriteLine(Ivan.CalculateInterestRate(3));

            Console.WriteLine();
            Console.WriteLine(Pesho.CalculateInterestRate(5));
            Console.WriteLine(Pesho.CalculateInterestAmound(5));

            Console.WriteLine(Pesho.CalculateTotal(5));
        }
    }
}
