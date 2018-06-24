using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public abstract class Account
    {
        public Decimal balance { get; protected set; }

        public Customer customerType { get; private set; }
        public int interestRate { get; private set; }

        public Account(Customer customer, Decimal money, int rate)
        {
            customerType = customer;
            balance = money;
            interestRate = rate;
        }
    }
}
