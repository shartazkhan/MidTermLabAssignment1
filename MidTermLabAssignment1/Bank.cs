using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MidTermLabAssignment1
{
    class Bank
    {

        private string bankName;
        private static Account[] myBank;
        public static int size;

        public Bank (string bankName, int size)
        {
            Bank.size = size;
            this.bankName = bankName;
            myBank = new Account[size];
        }

        



    
        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Account[] MyBank
        {
            get
            {
                return myBank;
            }
            set
            {
                myBank = value;
            }
        }
        public Account[] Accounts
        {
            set { Bank.myBank = value; }
            get { return Bank.myBank; }
        }

       


        public void PrintAllAccounts()
        {
            Console.WriteLine("-----------------" + BankName + "-----------------");
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].PrintAccount();
            }
            Console.WriteLine("-----------------" + "######" + "-----------------");
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        
        public void Transaction(int transactionType, [Optional] double amount, [Optional] Account receiver)
        {
            Console.WriteLine("-----------------" + BankName + "-----------------\n");
            Console.WriteLine("Please Enter a Account Number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (transactionType == 1 && myBank[i].AccountNumber== accountNumber)
                {
                    myBank[i].Deposite(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 2 && myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].Withdraw(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 3 && myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].Transfer(receiver, amount);
                    check = true;
                    break;
                }

            }
            if (check == false)
            {
                Console.WriteLine("You Choose a Wrong Number!!!! ");
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
               
                if (myBank[i].AccountNumber == accountNumber)
                {
                    // myBank[i].PrintAccount();

                    myBank[i] = null;
                    Console.WriteLine("Account Deleted");
                    flag = 1;
                    break;
                }
                else if (myBank[i] == null)
                {
                    for (int k = 0; k < (myBank.Length - i); k++)
                    {
                        myBank[i] = myBank[i + 1];
                    }
                    continue;
                }
                else
                {
                    flag = 0;

                }

            }
            if (flag == 0)
                Console.WriteLine("Account Not Found");
        }



    }
}
