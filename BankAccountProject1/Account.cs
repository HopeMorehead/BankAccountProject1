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
        protected decimal currentBalance;
        protected long accountNumber;



        //properties
        public decimal CurrentBalance { get; set; }
        public long AccountNumber { get;set; }
     


        public Account()
        {
         //default constructor
        }


        //custructor
        public Account( long accountNumber, decimal currentBalance)
        {
            this.accountNumber = accountNumber;
            this.currentBalance = currentBalance; 
        }


        //methods
        public decimal deposit(decimal currentBalance, decimal depositAmount)
        {

            Console.WriteLine("How much would you like to deposit.");
            depositAmount = decimal.Parse(Console.ReadLine());
            decimal depositBalance = currentBalance + depositAmount;
            return depositBalance;
        }



        //methods
        public decimal Withdrawal(decimal currentBalance, decimal withdrawalAmount)
        {

            do
            {
                Console.WriteLine("How much would you like to Withdrawal.");
                withdrawalAmount = decimal.Parse(Console.ReadLine());
                decimal withdrawalBalance = currentBalance - withdrawalAmount;

                if (withdrawalBalance > 1000.00M)
                {
                    return withdrawalBalance;
                }

                else if (withdrawalBalance <= 1000.00M)
                {
                    Console.WriteLine($"insufficient funds!Must have a minimum balance of {currentBalance}");
                    Console.Write("Current balance:");
                }
                return currentBalance;
               
            } while (currentBalance <= 0.00M);
        }
        


        public virtual decimal ViewCurrentBalance(decimal currentBalance)
        {
            return currentBalance;
        }
    }
}
