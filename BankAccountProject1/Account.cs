using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
    class Account
    {
        decimal currentBalance = 100.00M;
        decimal currentCheckingBalance;
        decimal currentSavingsBalance;


        //fields
        private string name;
        private int accountNumber;
        private decimal checkings;
        private decimal savings;
        

        //properties
        public string Name { get; }
        public int AccountNumber { get; }
        public decimal Checking { get; set; }
        public decimal Savings { get; set; }




        public Account()
        {
            //default constructor
        }


        //custructor
        public Account(string name, int accountNumber, decimal checkings, decimal savings)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.checkings = checkings;
            this.savings = savings;
        }



        //methods                      //temporary variables decimals
        public  decimal deposit(decimal currentBalance,decimal depositAmount)
        {
            Console.WriteLine("How much would you like to deposit.");
           depositAmount = decimal.Parse(Console.ReadLine());
           decimal depositBalance = currentBalance + depositAmount;
           return depositBalance;
        }






        //temporary variables decimals
       
        public decimal Withdrawal(decimal currentBalance,decimal withdrawalAmount)
        {
            Console.WriteLine("How much would you like to Withdrawal.");
            withdrawalAmount = decimal.Parse(Console.ReadLine());
            if (currentBalance <= 0.00M)
            {
                Console.WriteLine("Insufficient funds");              
            }
            decimal withdrawalBalance = currentBalance - withdrawalAmount;
            return withdrawalBalance;



        }




        public  decimal ViewCurrentBalance(decimal currentBalance)
        {
           // currentCheckingBalance = currentBalance;
            return currentBalance;
        }





     /*   public  decimal viewCurrentSavingsBalance(decimal currentSavingsBalance)
        {
            currentSavingsBalance = currentBalance;
            return currentSavingsBalance;
        }*/
    }
}
