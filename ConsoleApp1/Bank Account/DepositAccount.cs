using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
   public class DepositAccount : Account, IDepositAccount, IWithdrawAccount, IAccount
   {
       private static Customer customer;
       private static Decimal money;
       private static int rate;

       public DepositAccount(Customer inputCustomer, decimal inputMoney, int inputRate) : base(customer,money,rate)
       {
           if (money == Math.Abs(money) && money < 1000)
           {
               rate = 0;
           }

           customer = inputCustomer;
           money = inputMoney;
           rate = inputRate;
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
