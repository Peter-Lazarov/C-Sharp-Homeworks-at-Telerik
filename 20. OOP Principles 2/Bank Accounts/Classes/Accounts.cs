using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Accounts
    {
        private float amound;
        private float interest;
        private Customers customertype;

        public float Amound
        {
            get
            {
                return this.amound;
            }
            set
            {
                this.amound = value;
            }
        }
        public float InterestforMonth
        {
            get
            {
                return this.interest;
            }
            protected set
            {
                this.interest = value;
            }
        }
        public Customers customerType
        {
            get
            {
                return this.customertype;
            }
            protected set
            {
                this.customertype = value;
            }
        }

        public Accounts(Customers type, float amoundmoney, float interstrate)
        {
            this.customertype = type;
            this.amound = amoundmoney;
            this.interest = interstrate;
            Bank.AllAccounts.Add(this);
        }
        public virtual float CalculateInterestRate(int numberofMonths)
        {
            return numberofMonths * this.interest;
        }
        public float CalculateInterestAmound(int Months)
        {
            return CalculateInterestRate(Months) * this.amound / 100;
        }
        public float CalculateTotal(int months)
        {
            return CalculateInterestAmound(months) + this.amound;
        }
    }
}
