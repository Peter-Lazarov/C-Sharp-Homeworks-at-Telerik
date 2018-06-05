using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Mortgage : Accounts, IDeposit
    {
        public Mortgage(Customers type, float amoundMoney, float interestRate)
            : base(type, amoundMoney, interestRate)
        {
        }
        public void DepositMoney(float money)
        {
            this.Amound += money;
        }
        public override float CalculateInterestRate(int numberofMonths)
        {
            if ((this.customerType == Customers.Company) && (numberofMonths <= 12))
            {
                return this.InterestforMonth * 0.5f * numberofMonths;
            }
            else if ((this.customerType == Customers.Individual) && (numberofMonths <= 6))
            {
                return 0;
            }
            else
            {
                return this.InterestforMonth * numberofMonths;
            }
        }
    }
}
