using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Startup
    {
        static void Main(string[] args)
        {
            Bank myAccount = new DepositAccount(Customer.Individuals,100,5);
        
            myAccount.Deposit(2);



        }
    }
}
