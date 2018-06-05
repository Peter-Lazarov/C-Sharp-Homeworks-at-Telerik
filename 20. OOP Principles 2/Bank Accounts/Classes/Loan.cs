using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Loan : Accounts, IDeposit
    {
        public Loan(Customers type, float amoundMoney, float interestRate)
            : base(type, amoundMoney, interestRate)
        {
        }
        public void DepositMoney(float money)
        {
            this.Amound += money;
        }
        public override float CalculateInterestRate(int numberofMonths)
        {
            if ((this.customerType == Customers.Individual) && (numberofMonths > 2))
            {
                numberofMonths -= 3;
            }
            else if ((this.customerType == Customers.Company) && (numberofMonths > 1))
            {
                numberofMonths -= 2;
            }
            else
            {
                numberofMonths = 0;
            }
            return numberofMonths * this.InterestforMonth;
        }
    }
}
