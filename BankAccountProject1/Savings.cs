using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
    class Savings : Account
    {


        //I have access to base field
        //Added new field for method overrice
        //  private decimal checkingAccountBalance;




        public decimal savingsAccountBalance { get; set; }
        // 1 constructor




        public Savings(decimal savingsAccountBalance)
        {
            this.savingsAccountBalance = 1000.00M;
            base.accountNumber = 9281561117;
        }





        //cannot add parameters even if it is an overridden method
        public override decimal ViewCurrentBalance(decimal currentBalance)
        {
           savingsAccountBalance = currentBalance;


            //  return statement not retuning a value
            return currentBalance;
        }
















    }
}
