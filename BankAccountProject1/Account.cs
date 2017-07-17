using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
    class Account
    {
        //fields
      
        //Some access is nessassary for inheritance of tow different account numbers
        protected long accountNumber;
       // private decimal startcheckingsBalance;
       // private decimal startsavingsBalance;


        //properties
        public string Name { get; }
        public long AccountNumber { get; }
        public decimal Checking { get; set; }
        public decimal Savings { get; set; }




        public Account()
        {
            //default constructor
        }


        //custructor
        public Account(/*string name,*/ long accountNumber /*decimal startcheckingsBalance, decimal startSavingsBalance*/)
        {
           // this.name = name;
            this.accountNumber = accountNumber;
         //   this.startcheckingsBalance = startcheckingsBalance;
          //  this.startsavingsBalance = startSavingsBalance;
        }



        //methods                      //temporary variables decimals
        public decimal deposit(decimal currentBalance, decimal depositAmount)
        {
            Console.WriteLine("How much would you like to deposit.");
            depositAmount = decimal.Parse(Console.ReadLine());
            decimal depositBalance = currentBalance + depositAmount;
            return depositBalance;
        }






        //temporary variables decimals

       
        public decimal Withdrawal(decimal currentBalance, decimal withdrawalAmount)
        {

           // do
           // {
                Console.WriteLine("How much would you like to Withdrawal.");
                withdrawalAmount = decimal.Parse(Console.ReadLine());
                decimal withdrawalBalance = currentBalance - withdrawalAmount;
                return withdrawalBalance;
          //  } while (currentBalance >= 100.00M);
        }




        public virtual decimal ViewCurrentBalance(decimal currentBalance)
        {
           // currentBalance = currentBalance; ;
            return currentBalance;
        }

 



     /*   public  decimal viewCurrentSavingsBalance(decimal currentSavingsBalance)
        {
            currentSavingsBalance = currentBalance;
            return currentSavingsBalance;
        }*/
    }
}
