using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
   public class DepositAccount : BankAccount, IDeposit, IWithdraw, IBalance
   {

       public DepositAccount(Customer customer, decimal money, int rate) : base(customer,money,rate)
       {
           if (money == Math.Abs(money) && money < 1000)
           {
               this.interestRate = 0;
           }
       }

       public void Deposit(decimal money)
       {
           this.balance += money;
       }

       public void Withdraw(decimal money)
       {
           this.balance -= money;
       }

       public Decimal Balance()
       {
           return this.balance;
       }

        public override int CalculateInterestAmount(int months)
       {
           return months * this.interestRate;
       }
    }
}
