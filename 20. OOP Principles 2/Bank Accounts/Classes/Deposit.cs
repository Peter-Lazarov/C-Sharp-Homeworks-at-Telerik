using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Deposit : Accounts, IDeposit, IWithdraw
    {
        public Deposit(Customers type, float amoundMoney, float interestRate)
            : base(type, amoundMoney, interestRate)
        {
        }
        public void DepositMoney(float money)
        {
            this.Amound += money;
        }
        public void WithdrawMoney(float money)
        {
            if (this.Amound >= money)
            {
                this.Amound -= money;
            }
            else
            {
                this.Amound = 0;
            }
        }
        public override float CalculateInterestRate(int numberofMonths)
        {
            if (this.Amound < 1000)
            {
                return 0;
            }
            else
            {
                return numberofMonths * this.InterestforMonth;
            }
        }
    }
}
