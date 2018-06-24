using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
   public class DepositAccount : Account, IAccount
   {
       public DepositAccount(Customer customer, decimal money, int rate) : base(customer, money, rate)
       {

       }

       public void Deposit(decimal money)
       {
           this.balance += money;
       }

       public void Withdraw(decimal money)
       {
           this.balance -= money;
       }

       public int CalculateInterestAmount(int months)
       {
           return months * this.interestRate;
       }
    }
}
