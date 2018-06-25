using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
   public class MortgageAccount : Account , IDepositAccount , IAccount
   {
       public MortgageAccount(Customer customer,Decimal money,int rate) : base(customer,money,rate)
       {

       }

       public void Deposit(decimal money)
       {
           this.balance += money;
       }

       public int CalculateInterestAmount(int months)
       {
           if (this.customerType == Customer.Individuals)
           {
               return (months - 3) * this.interestRate;
           }
           else
           {
               return (months - 2) * this.interestRate;
           }
       }
    }
}
