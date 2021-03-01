using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment1
{
    class Program
    {
        /* static int AccountNumberGen()
         {
             int start = 10000000;
            // int accountNumber = (start + inc);

             return accountNumber;
         }*/

        static int AccountNumberGen(int inc)
        {
            int start = 999;
            int an = start+inc;
            return an;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many accounts do you want to create? ");
            int num = Convert.ToInt32(Console.ReadLine());
            Bank ourBank = new Bank("Developer's bank", num);

            for (int i=0; i < num; i++)
            {
                Console.WriteLine("\nAccount Number " + (i+1));
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Ammount: ");
                int ammount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("House no: ");
                int houseNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Road no: ");
                int roadNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Country: ");
                string country = Console.ReadLine();
              
                ourBank.AddAccount(new Account(name, ammount, AccountNumberGen(i), new Address(houseNo, roadNo, city ,country)));
                
            }
            ourBank.PrintAllAccounts();

            //Bank ourBank = new Bank("Developer's bank", 5);
            //ourBank.AddAccount(new Account( "Shakib", 2000, new Address(45, 10, "Dhaka","BD")));
            // ourBank.AddAccount(new Account("Mushfiq", 4000, new Address(45, 10, "Sylhet", "BD")));
            // ourBank.AddAccount(new Account("Tamim", 3000, new Address(5, 7, "Chittagong", "BD")));
            // ourBank.PrintAllAccounts();

            Console.ReadKey();

        }



           /* Address address1 = new Address(45,10,"Dhaka","Bangladesh");
            address1.PrintAddress();

            Account account1 = new Account("Shakib", 2000, address1);
            account1.PrintAccount();

            Account account2 = new Account("Shakib", 2000, address1);
            account1.PrintAccount();
           */

           //Console.ReadKey();
            

        }
    }

