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
            DepositAccount myAccount = new DepositAccount(Customer.Individuals,100,5);

            Console.WriteLine(myAccount.interestRate);



        }
    }
}
