using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
    class Menu
    {
        public void menu()


        {
            Dictionary<int, string> HomeScreen = new Dictionary<int, string>();

            HomeScreen.Add(1, " View Client Information");
            HomeScreen.Add(2, " View Account Balance");
            HomeScreen.Add(3, " Deposit Funds ");
            HomeScreen.Add(4, " Withdraw Funds");
            HomeScreen.Add(5, " Exit");
           

            foreach (KeyValuePair<int, string> options in HomeScreen)
            {

                Console.Write(options.Key);
                Console.WriteLine(options.Value);
            }



        }










    }
}
