using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    interface IWithdrawAccount
    {
        void Withdraw(decimal money);
    }
}
