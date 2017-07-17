using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject1
{
     class Client : Account
    {   //fiels
        private string name;
        private string address;
        private int age;





        //properties
        public string Name { get; }
        public string Address { get; set; }
        public int Age { get; set; }



        public Client()
        {

        }

        public Client( string name, string address, int age)
        {
            this.name = "Carlos Santana" ;
            this.address = "1234 Main St. Cleveland OH 44116" ;
            this.age = 35;
        }


        public void Information()
        {




        }

    }
}
