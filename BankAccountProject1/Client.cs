using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
     class Client : Account
    {   //fields
        protected string name = "Carlos Santana";
        private string address = "1234 Main St.Cleveland OH 44125";
        private int age = 65;





        //properties
        public string Name {get; }
        public string Address {get; set; }
        public int Age {get; set; }



        public Client()
        {

        }

        public Client( string name, string address, int age)
        {
            this.name = name;
            this.address = address ;
            this.age = age; 
        }


        public void Information()
        {
            Console.WriteLine($"Client name:{name}\nClient address:{address}\nClient age:{age}");


        }

    }
}
