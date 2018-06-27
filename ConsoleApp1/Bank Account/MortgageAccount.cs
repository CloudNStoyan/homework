using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
   public class MortgageAccount : BankAccount, IDeposit, IBalance
   {
       public MortgageAccount(Customer customer,Decimal money,int rate) : base(customer,money,rate)
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

       public override  int CalculateInterestAmount(int months)
       {
           int amount = 0;
           if (this.customerType == Customer.Companies)
           {
               if (months > 12)
               {
                   amount += ((this.interestRate / 2) * 12) + ((this.interestRate / 2) * months);
                   return amount;
               }
               else
               {
                   amount += (this.interestRate / 2) * months;
                   return amount;
               }
           }
           else
           {
               if (months > 6)
               {
                   amount += ((this.interestRate / 2) * 6) + ((this.interestRate / 2) * months);
                   return amount;
               }
               else
               {
                   amount += (this.interestRate / 2) * months;
                   return amount;
               }
           }
       }
    }
}
