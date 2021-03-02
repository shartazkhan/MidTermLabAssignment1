using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MidTermLabAssignment1
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;//1-1 Relation
                                //private double amount;

        Bank objBnak = new Bank();

        public Account()
        {

        }
        public Account(string accountName, double balance,int acn, Address address)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            this.accountNumber = acn;
        }


      
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine("Enter account number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < objBnak.MyBank.Length; i++)
            {
                if (objBnak.MyBank[i] == null)
                {
                    continue;
                }
                else if (objBnak.MyBank[i].accountNumber == accNo)
                {
                    Console.WriteLine("Account found!!");
                    objBnak.MyBank[i].Balance = objBnak.MyBank[i].Balance - amount;
                    Console.WriteLine("Your Current Balance is: " + objBnak.MyBank[i].Balance);
                    // flag = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Account not found!!");
                }
                // return balance;
            }

        }

        //public void Transfer(Account receiver,double amount)
        public void Transfer( double amount)
        {
            Console.WriteLine("Enter account number of receiver: ");
            int accNo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter account number of sender: ");
            int accNo = Convert.ToInt32(Console.ReadLine());
           // bool flag = false;
            for(int i = 0; i < objBnak.MyBank.Length; i++)
            {
                if (objBnak.MyBank[i] == null)
                {
                    continue;
                }
                else if (objBnak.MyBank[i].accountNumber == accNo)
                {
                    Console.WriteLine("Account found!!");
                    objBnak.MyBank[i].Balance = objBnak.MyBank[i].Balance - amount;
                    
                    Console.WriteLine("Your Current Balance is: " + objBnak.MyBank[i].Balance);
                   // flag = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Account not found!!");
                }
            }

            for (int i = 0; i < objBnak.MyBank.Length; i++)
            {
                //if (Bank.myBank[i].accountNumber == receiver.accountNumber)
                if (objBnak.MyBank[i].accountNumber == accNo1)
                {
                    objBnak.MyBank[i].Balance = objBnak.MyBank[i].Balance + amount;
                    Console.WriteLine("Transfer Compelted!!");
                    break;
                }
                else
                {
                    continue;
                }
            }

        }

        public void Deposit(double amount)
        {

            Console.WriteLine("Enter account number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < objBnak.MyBank.Length; i++)
            {
                if (objBnak.MyBank[i] == null)
                {
                    continue;
                }
                else if (objBnak.MyBank[i].accountNumber == accNo)
                {
                    Console.WriteLine("Account found!!");
                    objBnak.MyBank[i].Balance = objBnak.MyBank[i].Balance + amount;
                    Console.WriteLine("Your Current Balance is: " + objBnak.MyBank[i].Balance);
                    // flag = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Account not found!!");
                }
                // return balance;
            }
        }

        public void PrintAccount()
        {
            
            Console.WriteLine("\nAccount No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.address.PrintAddress();
        }



    }
}
