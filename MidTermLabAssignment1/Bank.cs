using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Bank()
        {
            
        }



        //int obj = Account.AccountNumber;

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

        public void Transaction(int typeT,int a)
        {
           

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
