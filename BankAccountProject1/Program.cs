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
            bool exit = true;

            //  Menu choices = new Menu();
            // choices.Prompt();

           
            Client personalClient    = new Client();
            Checking personalClient1 = new Checking();
            Checking personalClient2 = new Checking();
            Account personlClient3 = new Account(0987654321,500.00M);
            Savings personalClient4 = new Savings(1000.00M,1234567890);


          //  Client personalClient1 = new Client("Carlos Santana,", "1234 main st. Cleveland, OH", 65);

            do
            {
                Dictionary<int, string> HomeScreen = new Dictionary<int, string>();

                HomeScreen.Add(1, " View Client Information");
                HomeScreen.Add(2, " View Account Balance");
                HomeScreen.Add(3, " Deposit Funds ");
                HomeScreen.Add(4, " Withdraw Funds");
                HomeScreen.Add(5, " Exit");

                foreach (KeyValuePair<Int32, string> options in HomeScreen)
                {
                    Console.Write(options.Key);
                    Console.WriteLine(options.Value);
                }
                Console.WriteLine();
                Console.WriteLine("Pick an number option");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (userInput == 1)
                {
                    
                    personalClient.Information();
                    Console.WriteLine();
                }

                else if (userInput == 2)
                {

                 Console.WriteLine("What account would you like to access\n 1.Checking\n 2.Savings");
                 int viewBal = int.Parse(Console.ReadLine());

                    
                    if (viewBal == 1)
                    {
                        Console.WriteLine(personalClient2.GetAccountNumber(1234567890));
                        Console.WriteLine(personalClient1.ViewCurrentBalance(500.00M));
                        Console.WriteLine();
                    }
                    else if (viewBal == 2)
                    {
                        Console.WriteLine(personalClient4.GetAccountNumber(1234567890));
                        Console.WriteLine(personalClient4.ViewCurrentBalance(1000.00M));
                        Console.WriteLine();
                    }
                }
                else if (userInput == 3 )
                {
                    Console.WriteLine("What account would you like to access\n 1.Checking\n 2.Savings");
                    int choiceAccount = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    if (choiceAccount == 1)
                    {
                        Console.WriteLine(personlClient3.deposit(500.00M, 0.00M));
                        Console.WriteLine();
                    }
                    else if (choiceAccount == 2)
                    {

                        Console.WriteLine(personalClient4.deposit(1000.00M, 0.00M));
                        Console.WriteLine();
                    }
                }
                else if (userInput == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("What account would you like to access\n 1.Checking\n 2.Savings");
                    int choiceAccount1 = int.Parse(Console.ReadLine());
                    if (choiceAccount1 == 1)
                    {
                        Console.WriteLine(personalClient2.Withdrawal(500.00M, 0.00M));
                        Console.WriteLine();
                    }
                    else if (choiceAccount1 == 2)
                    {
                        Console.WriteLine(personalClient4.Withdrawal(1000.00M, 0.00M));
                        Console.WriteLine();
                    }
                }
                else if (userInput == 5)
                {
                    exit = false;
                  //  Console.ReadKey();
                }

            } while (exit == true);

            Console.Clear();
        }

    }

}



    


