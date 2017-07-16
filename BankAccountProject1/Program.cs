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
            Console.WriteLine(depositBalance);



           decimal withdrawalBalance = alex.Withdrawal(depositBalance, withdrawalAmount);
            Console.WriteLine(withdrawalBalance);



        }





    }

}
