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
        private Account[] myBank;
        public static int size;

        public Bank (string bankName, int size)
        {
            Bank.size = size;
            this.bankName = bankName;
            myBank = new Account[size];
            
        }

        //int obj = Account.AccountNumber;

        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] Accounts
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }
       
        public void PrintAllAccounts()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].PrintAccount();
            }
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

        public void RemoveAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].PrintAccount();
                    flag = 0;

                    int length = myBank.Length;

                    for (int k = 0; i < (length - i); i++)
                    {
                        myBank[i] = myBank[i + 1];
                    }
                    break;
                }
                else
                {
                    flag = 1;

                }

            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");
        }



    }
}
