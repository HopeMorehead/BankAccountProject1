using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
    class Savings : Account
    {

        
         public decimal savingsAccountBalance { get; set; }


        public long GetAccountNumber(long AccountNumber)
        {
            return AccountNumber;
        }



        public Savings(decimal savingsAccountBalance ,long accountNumber)
        {
            this.savingsAccountBalance = savingsAccountBalance;
            this.accountNumber = accountNumber;
        }





        public override decimal ViewCurrentBalance(decimal savingsAccountBalance)
        {

            CurrentBalance = savingsAccountBalance + CurrentBalance;
            return CurrentBalance;
        }
















    }
}
