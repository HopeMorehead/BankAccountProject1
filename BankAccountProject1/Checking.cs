using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
    class Checking : Account
    {   


         private decimal checkingAccountBalance = 500.00M;
         private long accountNumber = 8562349610;

        //I have access to base field
        //Added new field for method overrice
      //  private decimal checkingAccountBalance;



        public decimal CheckingAccountBalance { get; set; }
        public long AccountNumber
        {
            get
            {
                return this.accountNumber;

            }
        }
        

        // 1 constructor



        public Checking()
        {

        }
         public Checking(decimal checkingAccountBalance)
        {


          this.checkingAccountBalance =checkingAccountBalance;
         // base.accountNumber = 8562349610;
        }





        //cannot add parameters even if it is an overridden method
        public override decimal ViewCurrentBalance(decimal currentBalance)
        {
            checkingAccountBalance += currentBalance ;
 

           //  return statement not retuning a value
            return checkingAccountBalance;
        }










    }
}
