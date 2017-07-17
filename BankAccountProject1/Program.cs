using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
    class Program
    {
        static void Main(string[] args)
        {



            decimal currentBalance = 100.00M;
            decimal depositAmount = 0.00M;
            decimal withdrawalAmount = 0.00M;


            //can't seem to call return statement.Had to use a writeline
            Account alex = new Account();
            decimal depositBalance = alex.deposit(currentBalance, depositAmount);
            //  decimal due = depositAmount;
            Console.WriteLine(depositBalance);




            //withdrawal
            decimal withdrawalBalance = alex.Withdrawal(depositBalance, withdrawalAmount);
            if (withdrawalBalance <= 0.00M)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                Console.WriteLine(withdrawalBalance);
            }


            //current balance
            decimal ViewCurrentBalance = alex.ViewCurrentBalance(currentBalance);
            Console.WriteLine(currentBalance);



          //  Account Number
            Checking lauren = new Checking(/*1000.00M*/);
            Console.WriteLine(lauren.AccountNumber);




            //current balance
            decimal checkingAccountBalance = lauren.ViewCurrentBalance(currentBalance);
           // Checking Account balance
            Console.WriteLine(checkingAccountBalance);
          // Console.WriteLine(lauren.ViewCurrentBalance());


        }  

    }

}



    


