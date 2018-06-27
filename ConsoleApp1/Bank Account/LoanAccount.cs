using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public class LoanAccount : BankAccount, IDeposit, IBalance
    {
        public LoanAccount(Customer customer, decimal money, int rate) : base(customer, money, rate)
        {

        }

        public void Deposit(decimal money)
        {
            this.balance += money;
        }

        public Decimal Balance()
        {
            return this.balance;
        }

        public override int CalculateInterestAmount(int months)
        {
            int minus = (this.customerType == Customer.Individuals) ? 3 : 2;
            return (months - minus < 0) ? 0 : (months - minus) * this.interestRate;
        }
    }
}
