using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public interface IAccount
    {
        int CalculateInterestAmount(int months);
        
        
    }
}
