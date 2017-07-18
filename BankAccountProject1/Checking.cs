using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
    class Checking : Account
    {
        



        public long GetAccountNumber(long AccountNumber)
        {
            return AccountNumber;
        }


        //cannot add parameters even if it is an overridden method
        public override decimal ViewCurrentBalance(decimal checkingAccountBalance)
        {
            CurrentBalance += checkingAccountBalance + CurrentBalance;
            return CurrentBalance;
        }

    }
}
