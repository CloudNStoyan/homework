using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public abstract class BankAccount
    {
        protected Customer customerType;
        protected Decimal balance;
        protected int interestRate;

        protected BankAccount(Customer customer, Decimal money, int rate)
        {
            customerType = customer;
            balance = money;
            interestRate = rate;
        }

        public virtual int CalculateInterestAmount(int months)
        {
            return -1;
        }



    }
}
