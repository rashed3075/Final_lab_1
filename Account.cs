using System;
using System.Collections.Generic;
using System.Text;

namespace Final_th1
{
    abstract class Account
    {
        private string accNo;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        protected double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {

        }
        public Account(string accNo, string accName, double balance)
        {
            this.accNo = accNo;
            this.accName = accName;
            this.balance = balance;
        }
        abstract public void Deposit(double amount);
        
       abstract public  void  Withdraw(double amount);
        
        virtual public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("Acc No: " + accNo);
            Console.WriteLine("Balance: " + balance);
        }
    }
}
